using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Cercanias.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Cercanias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Cercanias;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Cercanias.Select;

public class SelectCercaniaInteractor : ISelectCercaniaInputPort
{
    private readonly IReadRepository<Cercania, int> _readRepository;
    private readonly ISelectCercaniaOutputPort _outputPort;
    
    public SelectCercaniaInteractor(IReadRepository<Cercania, int> readRepository, ISelectCercaniaOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new CercaniaActivosSpecification();
        
        var cercanias = await _readRepository.GetAllWithSpec(spec);
        
         
        IReadOnlyList<SelectCercaniaViewModel> viewModels = cercanias
            .Select(p => new SelectCercaniaViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}