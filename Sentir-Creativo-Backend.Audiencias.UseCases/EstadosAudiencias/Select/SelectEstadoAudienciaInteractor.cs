using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.EstadoAudiencias.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.EstadosAudiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.EstadosAudiencias.Select;

public class SelectEstadoAudienciaInteractor : ISelectEstadoAudienciaInputPort
{
    private readonly IReadRepository<EstadoAudiencia, int> _readRepository;
    private readonly ISelectEstadoAudienciaOutputPort _outputPort;
    
    public SelectEstadoAudienciaInteractor(IReadRepository<EstadoAudiencia, int> readRepository,
        ISelectEstadoAudienciaOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new EstadoAudienciaActivosSpecification();
        
        var estadoAudiencias = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectEstadoAudienciaViewModel> viewModels = estadoAudiencias
            .Select(p => new SelectEstadoAudienciaViewModel() { Id = p.Id, Nombre = p.Nombre, Color = p.Color })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(viewModels);
    }
}