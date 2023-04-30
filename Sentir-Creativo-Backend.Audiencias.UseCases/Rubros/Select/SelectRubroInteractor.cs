using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Rubros.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Rubros;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Rubros;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Rubros.Select;

public class SelectRubroInteractor : ISelectRubroInputPort
{
    private readonly IReadRepository<Rubro, int> _readRepository;
    private readonly ISelectRubroOutputPort _outputPort;
    
    public SelectRubroInteractor(IReadRepository<Rubro, int> readRepository, ISelectRubroOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new RubroActivosSpecification();

        var rubros = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectRubroViewModel> viewModels = rubros
            .Select(p => new SelectRubroViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}