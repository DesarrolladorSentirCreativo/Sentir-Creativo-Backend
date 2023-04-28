using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Ciudades.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Specifications.Ciudades;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Ciudades;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Direcciones.UseCases.Ciudades.Select;

public class SelectCiudadInteractor : ISelectCiudadInputPort
{
    private readonly IReadRepository<Ciudad, int> _readRepository;
    private readonly ISelectCiudadOutputPort _outputPort;
    
    public SelectCiudadInteractor(IReadRepository<Ciudad, int> readRepository, ISelectCiudadOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new CiudadActivosSpecification();

        var ciudades = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectCiudadViewModel> viewModels = ciudades
            .Select(p => new SelectCiudadViewModel() 
                { 
                    Id = p.Id, 
                    Nombre = p.Nombre,
                    PaisId = p.PaisId, 
                    RegionId = p.RegionId
                    
                })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}