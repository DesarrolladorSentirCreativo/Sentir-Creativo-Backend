using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.Update;

public class UpdateRolInteractor : IUpdateRolInputPort
{
    private readonly IReadRepository<Rol,int> _readRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUpdateRolOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateRolDto>> _validators;

    public UpdateRolInteractor(
        IReadRepository<Rol, int> readRepository,
        IUnitOfWork unitOfWork,
        IUpdateRolOutputPort outputPort,
        IEnumerable<IValidator<UpdateRolDto>> validators)
    {
        _readRepository = readRepository;
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
    }

    public async ValueTask Handle(UpdateRolDto dto)
    {
        //validamos los datos
        await Validator<UpdateRolDto>.Validate(dto, _validators);
        
        var spec = new RolActivoByIdSpecification(dto.Id);

        var rol = await _readRepository.GetByIdWithSpec(spec);

        if (rol == null) throw new NotFoundException("El rol no se encuentra registrada");
        
        rol.Nombre = dto.Nombre;
        rol.UpdatedBy = dto.UserId;
        rol.UpdatedAt = DateTime.Now;
        rol.Descripcion = dto.Descripcion;
        
        //guardamos el rol en la base de datos
        _unitOfWork.WriteRepository<Rol,int>().UpdateEntity(rol);
        
        //eliminamos los antiguos privilegios del rol
        _unitOfWork.WriteRepository<RolPrivilegio,int>().DeleteWhere(p => p.RolId == dto.Id);

        //eliminamos los antiguos los acuerdos del rol
        _unitOfWork.WriteRepository<RolAcuerdo,int>().DeleteWhere(p => p.RolId == dto.Id);
        
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
            throw new Exception("No se pudo actualizar el record de roles");
        }
        
        await _outputPort.Handle(rol.Id);
    }
}