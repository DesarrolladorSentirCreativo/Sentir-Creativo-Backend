using Microsoft.Extensions.Logging;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetById;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaArchivos;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaBitacoras;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaComentarios;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaCuponDescuentos;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaDifusiones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaOrganizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;
using Sentir_Creativo_Backend.Difusiones.Entities.ViewModels;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.GetById;

public class GetByIdAudienciaInteractor : IGetByIdAudienciaInputPort
{
    private readonly IReadRepository<Entities.POCOEntities.Audiencia, int> _audienciaReadRepository;
    private readonly IReadRepository<AudienciaBitacora, int> _audienciaBitacoraReadRepository;
    private readonly IReadRepository<AudienciaComentario, int> _audienciaComentarioReadRepository;
    private readonly IReadRepository<AudienciaArchivo,int> _audienciaArchivoReadRepository;
    private readonly IReadRepository<AudienciaCuponDescuento,int> _audienciaCuponDescuentoReadRepository;
    private readonly IReadRepository<AudienciaDifusion,int> _audienciaDifusionReadRepository;
    private readonly IGetByIdAudienciaOutputPort _outputPort;
    private readonly IReadRepository<AudienciaOrganizacion,int> _audienciaOrganizacionReadRepository;
    private readonly IReadRepository<UserAdmin,int> _userAdminReadRepository;

    public GetByIdAudienciaInteractor(
        ILogger<GetByIdAudienciaInteractor> logger,
        IReadRepository<Entities.POCOEntities.Audiencia, int> audienciaRedRepository,
        IReadRepository<AudienciaBitacora, int> audienciaBitacoraRedRepository,
        IReadRepository<AudienciaComentario, int> audienciaComentarioRedRepository,
        IReadRepository<AudienciaArchivo,int> audienciaArchivoReadRepository,
        IReadRepository<AudienciaCuponDescuento,int> audienciaCuponDescuentoObjetivoReadRepository,
        IReadRepository<AudienciaDifusion,int> audienciaDifusionReadRepository,
        IGetByIdAudienciaOutputPort outputPort,
        IReadRepository<AudienciaOrganizacion,int> audienciaOrganizacionReadRepository,
        IReadRepository<UserAdmin,int> userAdminReadRepository)
    {
        _audienciaReadRepository =  audienciaRedRepository;
        _audienciaBitacoraReadRepository = audienciaBitacoraRedRepository;
        _audienciaComentarioReadRepository = audienciaComentarioRedRepository;
        _audienciaArchivoReadRepository = audienciaArchivoReadRepository;
        _audienciaCuponDescuentoReadRepository = audienciaCuponDescuentoObjetivoReadRepository;
        _audienciaDifusionReadRepository = audienciaDifusionReadRepository;
        _outputPort = outputPort;
        _audienciaOrganizacionReadRepository = audienciaOrganizacionReadRepository;
        _userAdminReadRepository = userAdminReadRepository;
    }
    
    public async ValueTask Handle(int audienciaId)
    {
        var spec = new AudienciaIdSpecification(audienciaId);
        
        var audiencia = await _audienciaReadRepository.GetByIdWithSpec(spec);

        if (audiencia == null)
        {
            throw new ApplicationException("Audiencia no encontrada");
        }
        
        //obtener los comentarios de la audiencia
        var specComentarios = new AudienciaComentarioAudienciaIdSpecification(audienciaId);
        
        var comentarios = await _audienciaComentarioReadRepository.GetAllWithSpec(specComentarios);
        IReadOnlyList<ComentarioViewModel> comentariosViewModels = comentarios
            .Select(p =>
            {
                return new ComentarioViewModel()
                {
                    
                    Id = p.ComentarioId,
                    Descripcion = p.Comentario == null ? null : p.Comentario.Descripcion,
                    PublishedAt = p.Comentario == null ? null : p.Comentario.PublishedAt,
                    UserId = p.Comentario == null ? null :
                        p.Comentario.CreatedBy == null ? null : p.Comentario.CreatedBy,
                };
                
            })
                .ToList()
                .AsReadOnly();

        //obtener los archivos de la audiencia
        var specArchivos = new AudienciaArchivoAudienciaIdSpecification(audienciaId);
        var archivos = await _audienciaArchivoReadRepository.GetAllWithSpec(specArchivos);
        IReadOnlyList<ArchivoViewModel> archivosViewModels = archivos
            .Select(p => 
                new ArchivoViewModel()
                {
                    Id = p.Archivo!.Id, 
                    Path = p.Archivo!.Path, 
                    Nombre = p.Archivo!.Nombre!, 
                    PublishedAt  = p.Archivo.PublishedAt,
                    TipoArchivoId = p.Archivo.TipoArchivoId,
                    TipoArchivo = p.Archivo.TipoArchivo?.Nombre,
                    Publico = p.Archivo?.Publico
                })
            .ToList()
            .AsReadOnly();
        
        //obtener los cupones de descuento
        var specDescuentos = new AudienciaCuponDescuentoAudienciaIdSpecification(audienciaId);
        var cuponDescuentos = await _audienciaCuponDescuentoReadRepository.GetAllWithSpec(specDescuentos);
        
        IReadOnlyList<CuponDescuentoViewModel> cuponDescuentosViewModels = cuponDescuentos
            .Where(p => p.CuponDescuentoId != null)
            .Select(p => 
                new CuponDescuentoViewModel() { CuponDescuentoId = p.CuponDescuentoId })
            .ToList()
            .ToList()
            .AsReadOnly();
        
        //obtener las difusiones que tengan esta audiencia
        var specAudienciaDifusion = new AudienciaDifusionesIdAudienciaSpecification(audienciaId);
        var audienciasDifusiones = await _audienciaDifusionReadRepository.GetAllWithSpec(specAudienciaDifusion);
        
        IReadOnlyList<DifusionViewModel> audienciaDifusionesViewModels = audienciasDifusiones
            .Select(p => 
                new DifusionViewModel() 
                    { DifusionId = p.DifusionId
                    })
            .ToList()
            .AsReadOnly();

        //obtener las organizaciones 
        var specOrganizaciones = new AudienciaOrganizacionSpecification(audienciaId);
        var audienciaOrganizaciones = await _audienciaOrganizacionReadRepository.GetAllWithSpec(specOrganizaciones);
        
        IReadOnlyList<AudienciaOrganizacionViewModel> audienciaOrganizacionViewModels = audienciaOrganizaciones
            .Select(p => 
                new AudienciaOrganizacionViewModel()
                {
                    OrganizacionId = p.OrganizacionId
                }
                )
            .ToList()
            .AsReadOnly();

        var audienciaViewModel = new GetByIdAudienciaViewModel
        {
            Id = audiencia.Id,
            Nombre = audiencia.Nombre,
            Apellido = audiencia.Apellido,
            Profesion = audiencia.Profesion,
            Email = audiencia.Email,
            Celular = audiencia.Celular,
            OrganizacionId = audiencia.OrganizacionId,
            Departamento = audiencia.Departamento,
            Cargo = audiencia.Cargo,
            AntiguedadId = audiencia.AntiguedadId,
            CercaniaId = audiencia.CercaniaId,
            MotivacionId = audiencia.MotivacionId,
            EstadoAudienciaId = audiencia.EstadoId,
            PrefijoId = audiencia.PrefijoId,
            OrigenId = audiencia.OrigenId,
            Email2 = audiencia.Email2,
            Destacado = audiencia.Destacado,
            DocumentoIdentidad = audiencia.DocumentoIdentidad,
            Activo = audiencia.Activo,
            Comentarios = comentariosViewModels,
            Archivos = archivosViewModels,
            CuponDescuentos = cuponDescuentosViewModels,
            Difusiones = audienciaDifusionesViewModels,
            Organizaciones = audienciaOrganizacionViewModels,
            
        };

        await _outputPort.Handle(audienciaViewModel);

    }
}