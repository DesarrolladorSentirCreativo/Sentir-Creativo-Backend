using FluentValidation;
using Senitr_Creativo_Backend.Comentarios.Entities.Mappings;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Mappings;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Update;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Services;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.Bitacoras.Entities.Mappings;
using Sentir_Creativo_Backend.CuponDescuentos.Entities.Mappings;
using Sentir_Creativo_Backend.Difusiones.Entities.Mappings;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Update;

public class UpdateAudienciaInteractor : IUpdateAudienciaInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Entities.POCOEntities.Audiencia,int> _readRepository;
    private readonly IUpdateAudienciaOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateAudienciaDto>> _validators;
    private readonly IUpdateAudienciaService _updateAudienciaService;

    public UpdateAudienciaInteractor(
        IUnitOfWork unitOfWork,
        IReadRepository<Entities.POCOEntities.Audiencia,int> readRepository,
        IUpdateAudienciaOutputPort outputPort,
        IEnumerable<IValidator<UpdateAudienciaDto>> validators,
        IUpdateAudienciaService updateAudienciaService)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
        _updateAudienciaService = updateAudienciaService;
    }
    
    public async ValueTask Handle(UpdateAudienciaDto dto)
    {
        //validamos los datos
        await Validator<UpdateAudienciaDto>.Validate(dto, _validators);

        //validamos si existe la audiencia
        var audienciaUpdate = await _readRepository.GetByIdAsync(dto.Id);

        if (audienciaUpdate == null)
        {
            throw new Exception("La audiencia no se encuentra registrada");
        }
        
        //eliminamos las antiguas bitacoras de la audiencia
        _unitOfWork.WriteRepository<AudienciaBitacora,int>().DeleteWhere(p => p.AudienciaId == dto.Id);
        
        _unitOfWork.WriteRepository<AudienciaOrganizacion,int>().DeleteWhere(p => p.AudienciaId == dto.Id);
        
        //eliminamos las difuciones de la audiencia
        _unitOfWork.WriteRepository<AudienciaDifusion,int>().DeleteWhere(p => p.AudienciaId == dto.Id);
        
        //eliminamos los comentarios de la audiencia
        _unitOfWork.WriteRepository<AudienciaComentario,int>().DeleteWhere(p => p.AudienciaId == dto.Id);
        
        //eliminamos los archivos de la audiencia
        _unitOfWork.WriteRepository<AudienciaArchivo,int>().DeleteWhere(p => p.AudienciaId == dto.Id);
        
        //eliminamos cupones de descuento de la audiencia 
        _unitOfWork.WriteRepository<AudienciaCuponDescuento,int>().DeleteWhere(p => p.AudienciaId == dto.Id);


        var audienciaId = dto.Id;
        //guardamos  los nuevos cupones de descuento de la audiencia
        foreach (var audienciaCuponDescuento in dto.CuponDescuentos)
        {
            _unitOfWork.WriteRepository<AudienciaCuponDescuento,int>().AddEntity(new AudienciaCuponDescuento()
            {
                AudienciaId = audienciaId,
                CuponDescuentoId = audienciaCuponDescuento.CuponDescuentoId,
            });
        }
        

        
        //guardamos las nuevas difusiones de la audiencia
        foreach (var audienciaDifusion in dto.Difusiones)
        {
            _unitOfWork.WriteRepository<AudienciaDifusion,int>().AddEntity(new AudienciaDifusion()
            {
                AudienciaId = dto.Id,
                DifusionId = audienciaDifusion.DifusionId,
            });
        }
        

        
        //guardamos los nuevos comentarios de la audiencia
        foreach (var audienciaComentario in dto.Comentarios)
        {
            _unitOfWork.WriteRepository<AudienciaComentario,int>().AddEntity(new AudienciaComentario()
            {
                AudienciaId = dto.Id,
                ComentarioId = audienciaComentario.ComentarioId,
            });
        }
        

        
        //guardamos los nuevos archivos de la audiencia
        foreach (var audienciaArchivo in dto.Archivos)
        {
            _unitOfWork.WriteRepository<AudienciaArchivo,int>().AddEntity(new AudienciaArchivo()
            {
                AudienciaId = dto.Id,
                ArchivoId = audienciaArchivo.ArchivoId
            });
        }
        

        
        foreach (var audienciaOrganizacion in dto.Organizaciones)
        {
            _unitOfWork.WriteRepository<AudienciaOrganizacion,int>().AddEntity(new AudienciaOrganizacion()
            {
                AudienciaId = dto.Id,
                OrganizacionId= audienciaOrganizacion.OrganizacionId
            });
        }
        
   
        
        //guardamos los nuevos datos de la audiencia
        audienciaUpdate.Nombre = dto.Nombre;
        audienciaUpdate.Apellido = dto.Apellido;
        audienciaUpdate.Email = dto.Email;
        audienciaUpdate.Profesion = dto.Profesion;
        audienciaUpdate.Celular = dto.Celular;
        audienciaUpdate.Departamento = dto.Departamento;
        audienciaUpdate.Cargo = dto.Cargo;
        audienciaUpdate.AntiguedadId = dto.AntiguedadId;
        audienciaUpdate.CercaniaId = dto.CercaniaId;
        audienciaUpdate.MotivacionId = dto.MotivacionId;
        audienciaUpdate.EstadoId = dto.EstadoAudienciaId;
        audienciaUpdate.PrefijoId = dto.PrefijoId;
        audienciaUpdate.OrigenId = dto.OrigenId;
        audienciaUpdate.Email2 = dto.Email2;
        audienciaUpdate.DocumentoIdentidad = dto.DocumentoIdentidad;
        audienciaUpdate.Activo = true;
        audienciaUpdate.UpdatedAt = DateTime.Now;
        audienciaUpdate.UpdatedBy = dto.UserId;
        
        _unitOfWork.WriteRepository<Entities.POCOEntities.Audiencia,int>().UpdateEntity(audienciaUpdate);
        
        //guardamos los cambios en la base de datos
       var result = await _unitOfWork.Complete();
       
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de audiencias");
        }
        
        //se mapea las colecciones
        var idCuponDescuentos = CuponDescuentoMapping.Handle(dto.CuponDescuentos);
        var idDifusiones = DifusionMapping.Handle(dto.Difusiones);
        var idArchivos = ArchivoMapping.Handle(dto.Archivos);
        var idComentarios = CommentarioMapping.Handle(dto.Comentarios);

        //mandamos los datos para que se envien al webhooks
        await _updateAudienciaService.Handle(new UpdateAudienciaViewModel()
        {
            Id = audienciaUpdate.Id,
            Nombre = audienciaUpdate.Nombre,
            Apellido = audienciaUpdate.Apellido,
            Profesion = audienciaUpdate.Profesion,
            Email = audienciaUpdate.Email,
            Celular = audienciaUpdate.Celular,
            OrganizacionId = audienciaUpdate.OrganizacionId,
            Departamento = audienciaUpdate.Departamento,
            Cargo = audienciaUpdate.Cargo,
            CercaniaId = audienciaUpdate.CercaniaId,
            AntiguedadId = audienciaUpdate.AntiguedadId,
            MotivacionId = audienciaUpdate.MotivacionId,
            EstadoAudienciaId = audienciaUpdate.EstadoId,
            PrefijoId = audienciaUpdate.PrefijoId,
            OrigenId = audienciaUpdate.OrigenId,
            Email2 = audienciaUpdate.Email2,
            Destacado = audienciaUpdate.Destacado,
            DocumentoIdentidad = audienciaUpdate.DocumentoIdentidad,
            Activo = audienciaUpdate.Activo,
            PublishedAt = audienciaUpdate.PublishedAt,
            CuponDescuentos = idCuponDescuentos,
            Difusiones = idDifusiones,
            Archivos = idArchivos,
            Comentarios = idComentarios
        });
        
        await _outputPort.Handle(audienciaUpdate.Id);
    }
}