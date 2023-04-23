using Sentir_Creativo_Backend.Difusiones.BusinessObject.Ports;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.Specifications;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.ViewModels;
using Sentir_Creativo_Backend.Difusiones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Difusiones.UseCases.Difusiones.Select;

public class SelectDifusionInteractor : ISelectDifusionInputPort
{
    private readonly IReadRepository<Difusion, int> _readRepository;
    private readonly ISelectDifusionOutputPort _outputPort;
    
    public SelectDifusionInteractor(IReadRepository<Difusion, int> readRepository, ISelectDifusionOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new DifusionActivosSpecification();

        var difusiones = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectDifusionViewModel> viewModels = difusiones
            .Select(p => new SelectDifusionViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}