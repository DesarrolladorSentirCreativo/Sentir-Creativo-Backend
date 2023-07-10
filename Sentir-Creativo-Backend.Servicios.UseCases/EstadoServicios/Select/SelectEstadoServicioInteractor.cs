using Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.EstadoServicios;

namespace Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Select;

public class SelectEstadoServicioInteractor : ISelectEstadoServicioInputPort
{
    private readonly IReadRepository<EstadoServicio, int> _readRepository;
    private readonly ISelectEstadoServicioOutputPort _outputPort;

    public SelectEstadoServicioInteractor(
        IReadRepository<EstadoServicio, int> readRepository,
        ISelectEstadoServicioOutputPort outputPort
       )
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        var spec = new EstadoServicioActivosSpecification();
        var estadoServicios = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectEstadoServicioViewModel> viewModels = estadoServicios
            .Select(p => new SelectEstadoServicioViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}