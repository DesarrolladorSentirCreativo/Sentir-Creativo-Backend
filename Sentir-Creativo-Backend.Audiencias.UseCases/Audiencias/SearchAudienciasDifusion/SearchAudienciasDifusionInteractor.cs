using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.SearchAudienciaDifusiones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.Difusiones.Entities.POCOEntities;
using Sentir_Creativo_Backend.Difusiones.Entities.Specifications;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.SearchAudienciasDifusion;

public class SearchAudienciasDifusionInteractor : ISearchAudienciasDifusionInputPort
{
    private readonly IReadRepository<AudienciaDifusion,int> _readAudienciaDifusionRepository;
    private readonly IReadRepository<Difusion,int> _readDifusionRepository;
    private readonly ISearchAudienciasDifusionOutputPort _outputPort;
    
    public SearchAudienciasDifusionInteractor(
        IReadRepository<AudienciaDifusion,int> readAudienciaDifusionRepository, 
        ISearchAudienciasDifusionOutputPort outputPort,
        IReadRepository<Difusion,int> readDifusionRepository)
    {
        _readAudienciaDifusionRepository = readAudienciaDifusionRepository;
        _readDifusionRepository = readDifusionRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int difusionId)
    {
        var spec = new DifusionIdSpecification(difusionId);

        var difusion = await _readDifusionRepository.GetByIdWithSpec(spec);
        
        var specAudienciaDifusion = new AudienciaDifusionIdAudienciaSpecification(difusionId);

        var audienciasDifusion = await _readAudienciaDifusionRepository.GetAllWithSpec(specAudienciaDifusion);

        IReadOnlyList<AudienciaViewModel> audiencias = audienciasDifusion
            .Select(p =>
                new AudienciaViewModel()
                {
                    Id = p.Id, 
                    Nombre = p.Audiencia!.Nombre, 
                    Apellido = p.Audiencia!.Apellido,
                    Profesion = p.Audiencia!.Profesion,
                    Activo = p.Audiencia!.Activo,
                    Organizacion = p.Audiencia!.Organizacion!.Nombre,
                    Email = p.Audiencia.Email,
                    Celular = p.Audiencia.Celular,
                    DocumentoIdentidad = p.Audiencia.DocumentoIdentidad
                })
            .ToList()
            .AsReadOnly();

        var viewModel = new SearchAudienciasDifusionViewModel
        {
            DifusionId = difusion.Id,
            Nombre = difusion.Nombre,
            Descripcion = difusion.Descripcion,
            Activo = difusion.Activo,
            PlataformaId = difusion.PlataformaId,
            Plataforma = difusion.Plataforma?.Nombre,
            CuponDescuentoId = difusion.CuponDescuentoId,
            CuponDescuento = difusion.CuponDescuento?.Descripcion,
            ColeccionId = difusion.ColeccionId,
            Coleccion = difusion.Coleccion?.Nombre,
            PlantillaId = difusion.PlantillaId,
            Plantilla = difusion.Plantilla?.Nombre,
            Slogan = difusion.Slogan,
            Asunto = difusion.Asunto,
            PreHeader = difusion.PreHeader,
            Audiencias = audiencias
            
        };
        
        await _outputPort.Handle(viewModel);

    }
}