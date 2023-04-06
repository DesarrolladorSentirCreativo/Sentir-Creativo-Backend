using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Prefijos.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Prefijos;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Prefijos;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Prefijos.Select;

public class SelectPrefijoInteractor : ISelectPrefijoInputPort
{
    private readonly IReadRepository<Prefijo, int> _readRepository;
    private readonly ISelectPrefijoOutputPort _outputPort;
    
    public SelectPrefijoInteractor(IReadRepository<Prefijo, int> readRepository, ISelectPrefijoOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new PrefijoActivosSpecification();
        
        var prefijos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectPrefijoViewModel> viewModels = prefijos
            .Select(p => new SelectPrefijoViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}