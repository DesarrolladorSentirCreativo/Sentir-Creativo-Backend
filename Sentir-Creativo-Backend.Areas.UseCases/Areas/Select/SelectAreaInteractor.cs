using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Ports.Areas.Select;
using Sentir_Creativo_Backend.Areas.BusinessObject.Specifications.Areas;
using Sentir_Creativo_Backend.Areas.BusinessObject.ViewModels.Areas;
using Sentir_Creativo_Backend.Areas.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Areas.UseCases.Areas.Select;

public class SelectAreaInteractor : ISelectAreaInputPort
{
    private readonly IReadRepository<Area, int> _readRepository;
    private readonly ISelectAreaOutputPort _outputPort;
    
    public SelectAreaInteractor(IReadRepository<Area, int> readRepository, ISelectAreaOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new AreaActivosSpecification();

        var areas = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectAreaViewModel> viewModels = areas
            .Select(p => new SelectAreaViewModel() { Id = p.Id, Nombre = p.Nombre! })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}