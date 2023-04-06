using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Motivaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Motivaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Motivaciones;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Motivaciones.Select;

public class SelectMotivacionInteractor : ISelectMotivacionInputPort
{
    private readonly IReadRepository<Motivacion, int> _readRepository;
    private readonly ISelectMotivacionOutputPort _outputPort;
    
    public SelectMotivacionInteractor(IReadRepository<Motivacion, int> readRepository, ISelectMotivacionOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new MotivacionActivosSpecification();
            
        var motivaciones = await _readRepository.GetAllWithSpec(spec);
        
         
        IReadOnlyList<SelectMotivacionViewModel> viewModels = motivaciones
            .Select(p => new SelectMotivacionViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}