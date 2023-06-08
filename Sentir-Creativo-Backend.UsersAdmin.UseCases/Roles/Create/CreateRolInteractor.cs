using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.Create;

public class CreateRolInteractor : ICreateRolInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateRolOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateRolDto>> _validators;

    public CreateRolInteractor(
        IUnitOfWork unitOfWork, 
        ICreateRolOutputPort outputPort, 
        IEnumerable<IValidator<CreateRolDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
    }

    public async ValueTask Handle(CreateRolDto dto)
    {
         //validamos los datos
        await Validator<CreateRolDto>.Validate(dto, _validators);
        
        //creamos el rol
        var rol = new Rol()
        {
            Nombre = dto.Nombre, 
            Descripcion = dto.Descripcion,
            Activo = true,
            CreatedAt= DateTime.Now,
            CreatedBy = dto.UserId, 
            PublishedAt = DateTime.Now,
        };
        
        //guardamos el rol en la base de datos
        _unitOfWork.WriteRepository<Rol,int>().AddEntity(rol);
        
        await _unitOfWork.Complete();

        //guardamos todos los privilegios del rol
        foreach (var privilegio in dto.Privilegios)
        {
            _unitOfWork.WriteRepository<RolPrivilegio,int>().AddEntity(new RolPrivilegio()
            {
                RolId = rol.Id,
                PrivilegioId = privilegio.PrivilegioId
            });
        }

        //guardamos todos los acuerdos del rol
        foreach (var acuerdo in dto.Acuerdos)
        {
            _unitOfWork.WriteRepository<RolAcuerdo,int>().AddEntity(new RolAcuerdo()
            {
                RolId = rol.Id,
                AcuerdoId = acuerdo.AcuerdoId
            });
        }
        //confirmamos los cambios en la base de datos
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de roles");
        }
        
        await _outputPort.Handle(rol.Id);

    }
}