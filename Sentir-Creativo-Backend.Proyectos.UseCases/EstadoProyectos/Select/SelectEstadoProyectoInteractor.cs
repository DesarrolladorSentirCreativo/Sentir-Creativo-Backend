using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports.EstadoProyectos.Select;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Specifications.EstadoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.EstadoProyectos;
using Sentir_Creativo_Backend.Proyectos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Proyectos.UseCases.EstadoProyectos.Select;

public class SelectEstadoProyectoInteractor : ISelectEstadoProyectoInputPort
{
    private readonly IReadRepository<EstadoProyecto, int> _readRepository;
    private readonly ISelectEstadoProyectoOuputPort _outputPort;
    
    public SelectEstadoProyectoInteractor(IReadRepository<EstadoProyecto, int> readRepository, ISelectEstadoProyectoOuputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new EstadoProyectoActivosSpecification();

        var estadoProyectos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectEstadoProyectoViewModel> viewModels = estadoProyectos
            .Select(p => new SelectEstadoProyectoViewModel() { Id = p.Id, Nombre = p.Nombre, Color = p.Color })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}