using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.Create;

public class CreatePrivilegioInteractor : ICreatePrivilegioInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreatePrivilegioOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreatePrivilegioDto>> _validators;

    public CreatePrivilegioInteractor(
        IUnitOfWork unitOfWork,
        ICreatePrivilegioOutputPort outputPort,
        IEnumerable<IValidator<CreatePrivilegioDto>> validators)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _validators = validators;
    }
        
    
    public async ValueTask Handle(CreatePrivilegioDto dto)
    {
        //validamos los datos
        await Validator<CreatePrivilegioDto>.Validate(dto, _validators);
        
        List<string> accesoIds = new List<string>();
        
        //guardamos todos los accesos de la audiencia
        foreach (var acceso in dto.Accesos)
        {
            Guid uuid = Guid.NewGuid();
            
            var newAcceso = new Acceso()
            {
                Id = uuid.ToString(),
                Crear = acceso.Crear,
                Actualizar = acceso.Actualizar,
                Eliminar = acceso.Eliminar,
                Ver = acceso.Ver,
                Listar = acceso.Listar,
                CreatedBy = dto.UserId,
                CreatedAt = DateTime.Now
            };
            
            _unitOfWork.WriteRepository<Acceso,string>().AddEntity(newAcceso);
            
            // Guardar el ID del acceso insertado en la lista
            accesoIds.Add(newAcceso.Id);
            
        }
        
        Guid uuidPrivilegio = Guid.NewGuid();
        
        //guardamos el privilegio
        var privilegio = new Privilegio()
        {
            Id = uuidPrivilegio.ToString(),
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            CategoriaId = dto.CategoriaId,
            CreatedBy = dto.UserId,
            CreatedAt = DateTime.Now
        };

        _unitOfWork.WriteRepository<Privilegio,string>().AddEntity(privilegio);
        
        //creamos los accesos del privilegio
        for (int i = 0; i < accesoIds.Count; i++)
        {
            string accesoId = accesoIds[i];

            var privilegioAcceso = new PrivilegioAcceso()
            {
                AccesoId = accesoId,
                PrivilegioId = privilegio.Id,
            };
            
            _unitOfWork.WriteRepository<PrivilegioAcceso,int>().AddEntity(privilegioAcceso);
        }

        await _unitOfWork.Complete();
        
        await _outputPort.Handle(privilegio.Id);

    }
}