using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.GetAll;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.GetAll;

public class GetAllOrganizacionInteractor : IGetAllOrganizacionInputPort
{
    private readonly IReadRepository<Organizacion, int> _readRepository;
    private readonly IGetAllOrganizacionOutputPort _outputPort;
    
    public GetAllOrganizacionInteractor(IReadRepository<Organizacion, int> readRepository, IGetAllOrganizacionOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new OrganizacionActivosSpecification();

        var organizacionDirecciones = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllOrganizacionViewModel> viewModels = organizacionDirecciones
            .Select(p => new GetAllOrganizacionViewModel()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Website = p.Website,
                Facebook = p.Facebook,
                Twitter = p.Twitter,
                Instagram = p.Instagram,
                Historial = p.Historial,
                Email = p.Email,
                RubroId = p.RubroId,
                Telefono = p.Telefono,
                Activo = p.Activo,
                PublishedAt = p.PublishedAt
            })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}