using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.Select;

public class SelectOrganizacionInteractor : ISelectOrganizacionInputPort
{
    private readonly IReadRepository<Organizacion, int> _readRepository;
    private readonly ISelectOrganizacionOutputPort _outputPort;
    
    public SelectOrganizacionInteractor(IReadRepository<Organizacion, int> readRepository, ISelectOrganizacionOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new OrganizacionActivosSpecification();

        var organizaciones = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectOrganizacionViewModel> viewModels = organizaciones
            .Select(p => new SelectOrganizacionViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}