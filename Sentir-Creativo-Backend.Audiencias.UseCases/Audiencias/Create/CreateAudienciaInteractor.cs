using FluentValidation;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Create;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Services;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.CuponDescuentos.Entities.Mappings;
using Sentir_Creativo_Backend.Difusiones.Entities.Mappings;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Create;

public class CreateAudienciaInteractor : ICreateAudienciaInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateAudienciaOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateAudienciaDto>> _validators;
    private readonly ICreateAudienciaService _createAudienciaService;
    
    public CreateAudienciaInteractor(
        IUnitOfWork unitOfWork,
        ICreateAudienciaOutputPort outputPort,
        IEnumerable<IValidator<CreateAudienciaDto>> validators,
        ICreateAudienciaService createAudienciaService)
    {
         _unitOfWork = unitOfWork;
         _outputPort = outputPort;
         _validators = validators;
         _createAudienciaService = createAudienciaService;
    }
    
    public async ValueTask Handle(CreateAudienciaDto dto)
    {
        //validamos los datos
        await Validator<CreateAudienciaDto>.Validate(dto, _validators);
        
        //creamos la audiencia
        var audiencia = new Entities.POCOEntities.Audiencia()
        {
            Nombre = dto.Nombre, 
            Apellido = dto.Apellido, 
            Profesion = dto.Profesion, 
            Email = dto.Email, 
            Celular = dto.Celular,
            Departamento = dto.Departamento, 
            Cargo = dto.Cargo, 
            CercaniaId = dto.CercaniaId, 
            AntiguedadId = dto.AntiguedadId, 
            MotivacionId = dto.MotivacionId, 
            EstadoId = dto.EstadoAudienciaId, 
            PrefijoId = dto.PrefijoId,
            OrigenId = dto.OrigenId,
            Email2 = string.IsNullOrEmpty(dto.Email2) ? null : dto.Email2,
            Destacado = true,
            DocumentoIdentidad = dto.DocumentoIdentidad,
            Activo = true,
            CreatedAt= DateTime.Now,
            CreatedBy = dto.UserId, 
            PublishedAt = DateTime.Now,
        };
        
        //guardamos la audiencia en la base de datos
        _unitOfWork.WriteRepository<Entities.POCOEntities.Audiencia>().AddEntity(audiencia);
        
        await _unitOfWork.Complete();

        //guardamos todos los cupones de descuento de la audiencia
        foreach (var audienciaCuponDescuento in dto.CuponDescuentos)
        {
            _unitOfWork.WriteRepository<AudienciaCuponDescuento>().AddEntity(new AudienciaCuponDescuento()
            {
                AudienciaId = audiencia.Id,
                CuponDescuentoId = audienciaCuponDescuento.CuponDescuentoId,
            });
        }
        
        //guardamos todos los comentarios de la audiencia
        
        foreach (var audienciaComentario in dto.Comentarios)
        {
            _unitOfWork.WriteRepository<AudienciaComentario>().AddEntity(new AudienciaComentario()
            {
                AudienciaId = audiencia.Id,
                ComentarioId = audienciaComentario.ComentarioId
            });
        }
        
        //guardamos todos las difusiones de la audiencia
        foreach (var audienciaDifusion in dto.Difusiones)
        {
            _unitOfWork.WriteRepository<AudienciaDifusion>().AddEntity(new AudienciaDifusion()
            {
                AudienciaId = audiencia.Id,
                DifusionId = audienciaDifusion.DifusionId,
            });
        }
        
        //guardamos todas las organizaciones de la audiencia
        foreach (var audienciaOrganizacion in dto.Organizaciones)
        {
            _unitOfWork.WriteRepository<AudienciaOrganizacion>().AddEntity(new AudienciaOrganizacion()
            {
                AudienciaId = audiencia.Id,
                OrganizacionId = audienciaOrganizacion.OrganizacionId,
            });
        }
        
        //confirmamos los cambios en la base de datos
        var result = await _unitOfWork.Complete();
        
        //se evalua si todo funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de audiencias");
        }


        var idCuponDescuentos = CuponDescuentoMapping.Handle(dto.CuponDescuentos);

        var idDifusiones = DifusionMapping.Handle(dto.Difusiones);
        
        //mandamos la audiencia al web hook de make
        await _createAudienciaService.Handle(new CreateAudienciaViewModel()
        {
            Id = audiencia.Id,
            Nombre = audiencia.Nombre,
            Apellido = audiencia.Apellido,
            Profesion = audiencia.Profesion,
            Email = audiencia.Email,
            Celular = audiencia.Celular,
            Departamento = audiencia.Departamento,
            Cargo = audiencia.Cargo,
            CercaniaId = audiencia.CercaniaId,
            AntiguedadId = audiencia.AntiguedadId,
            MotivacionId = audiencia.MotivacionId,
            EstadoAudienciaId = audiencia.EstadoId,
            PrefijoId = audiencia.PrefijoId,
            OrigenId = audiencia.OrigenId,
            Email2 = audiencia.Email2,
            Destacado = audiencia.Destacado,
            DocumentoIdentidad = audiencia.DocumentoIdentidad,
            Activo = audiencia.Activo,
            PublishedAt = audiencia.PublishedAt,
            CuponDescuentos = idCuponDescuentos,
            Difusiones = idDifusiones,
        });
        
        await _outputPort.Handle(audiencia.Id);

    }
}