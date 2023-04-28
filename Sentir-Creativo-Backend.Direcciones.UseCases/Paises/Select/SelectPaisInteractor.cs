using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Paises.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Specifications.Paises;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Paises;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Direcciones.UseCases.Paises.Select;

public class SelectPaisInteractor : ISelectPaisInputPort
{
    private readonly IReadRepository<Pais, int> _readRepository;
    private readonly ISelectPaisOutputPort _outputPort;
    
    public SelectPaisInteractor(IReadRepository<Pais, int> readRepository, ISelectPaisOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new PaisActivosSpecification();

        var paises = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectPaisViewModel> viewModels = paises
            .Select(p => new SelectPaisViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}