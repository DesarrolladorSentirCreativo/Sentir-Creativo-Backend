using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Specifications.TipoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.TiposProyectos;
using Sentir_Creativo_Backend.Proyectos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Proyectos.UseCases.TipoProyectos.Select;

public class SelectTipoProyectoInteractor : ISelectTipoProyectoInputPort
{
    private readonly IReadRepository<TipoProyecto, int> _readRepository;
    private readonly ISelectTipoProyectoOutPort _outputPort;
    
    public SelectTipoProyectoInteractor(IReadRepository<TipoProyecto, int> readRepository, ISelectTipoProyectoOutPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    
    public async ValueTask Handle()
    {
        var spec = new TipoProyectoActivosSpecification();

        var tipoProyectos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectTipoProyectoViewModel> viewModels = tipoProyectos
            .Select(p => new SelectTipoProyectoViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}