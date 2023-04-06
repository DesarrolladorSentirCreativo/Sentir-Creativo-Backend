using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Origenes.SelectOrigen;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Origenes;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Origenes.Select;

public class SelectOrigenInteractor : ISelectOrigenInputPort
{
    private readonly IReadRepository<Origen, int> _readRepository;
    private readonly ISelectOrigenOutputPort _outputPort;
    
    public SelectOrigenInteractor(IReadRepository<Origen, int> readRepository, ISelectOrigenOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        var spec = new OrigenActivosSpecification();

        var origenes = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectOrigenViewModel> viewModels = origenes
            .Select(p => new SelectOrigenViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}