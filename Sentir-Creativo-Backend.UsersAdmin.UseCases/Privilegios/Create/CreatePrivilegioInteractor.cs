using FluentValidation;
using Microsoft.Extensions.Logging;
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
    private readonly ILogger<CreatePrivilegioInteractor> _logger;

    public CreatePrivilegioInteractor(
        IUnitOfWork unitOfWork,
        ICreatePrivilegioOutputPort outputPort,
        IEnumerable<IValidator<CreatePrivilegioDto>> validators,
        ILogger<CreatePrivilegioInteractor> logger)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _validators = validators;
        _logger = logger;
    }
        
    
    public async ValueTask Handle(CreatePrivilegioDto dto)
    {
        // Validamos los datos
        await Validator<CreatePrivilegioDto>.Validate(dto, _validators);

        // Guardamos todos los accesos de la audiencia
        var accesoIds = new List<string>();

        foreach (var acceso in dto.Accesos)
        {
            var newAcceso = new Acceso()
            {
                Id = Guid.NewGuid().ToString(),
                Crear = acceso.Crear,
                Actualizar = acceso.Actualizar,
                Eliminar = acceso.Eliminar,
                ColeccionId = acceso.ColeccionId,
                Ver = acceso.Ver,
                Listar = acceso.Listar,
                CreatedBy = dto.UserId,
                CreatedAt = DateTime.Now
            };

            _unitOfWork.WriteRepository<Acceso, string>().AddEntity(newAcceso);

            // Guardamos el ID del acceso insertado en la lista
            accesoIds.Add(newAcceso.Id);
        }

        // Guardamos el privilegio
        var privilegio = new Privilegio()
        {
            Id = Guid.NewGuid().ToString(),
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            CategoriaId = dto.CategoriaId,
            CreatedBy = dto.UserId,
            CreatedAt = DateTime.Now,
            Activo = true
        };

        _unitOfWork.WriteRepository<Privilegio, string>().AddEntity(privilegio);
        
        // Creamos los accesos del privilegio
        foreach (string accesoId in accesoIds)
        {
            var privilegioAcceso = new PrivilegioAcceso()
            {
                AccesoId = accesoId,
                PrivilegioId = privilegio.Id,
            };
            _unitOfWork.WriteRepository<PrivilegioAcceso, int>().AddEntity(privilegioAcceso); 
            
        }

        var primerAccesoId = accesoIds[0]; // Obtener el primer ID de la lista accesoIds

        var primerPrivilegioAcceso = new PrivilegioAcceso()
        {
            AccesoId = primerAccesoId,
            PrivilegioId = privilegio.Id,
        };

        _unitOfWork.WriteRepository<PrivilegioAcceso, int>().AddEntity(primerPrivilegioAcceso);
        
        var result = await _unitOfWork.Complete();

        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de privilegios");
        }

        await _outputPort.Handle(privilegio.Id);

    }
}