using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Regiones.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Specifications.Regiones;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Regiones;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Direcciones.UseCases.Regiones.Select;

public class SelectRegionInteractor : ISelectRegionInputPort
{
    private readonly IReadRepository<Region, int> _readRepository;
    private readonly ISelectRegionOutputPort _outputPort;
    
    public SelectRegionInteractor(IReadRepository<Region, int> readRepository, ISelectRegionOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new RegionActivosSpecification();

        var regiones = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectRegionViewModel> viewModels = regiones
            .Select(p => new SelectRegionViewModel() { Id = p.Id, Nombre = p.Nombre, PaisId = p.PaisId })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}