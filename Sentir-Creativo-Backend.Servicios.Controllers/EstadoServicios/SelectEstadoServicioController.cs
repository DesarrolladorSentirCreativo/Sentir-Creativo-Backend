using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.EstadoServicios;

namespace Sentir_Creativo_Backend.Servicios.Controllers.EstadoServicios;

public class SelectEstadoServicioController : ISelectEstadoServicioController
{
    private readonly ISelectEstadoServicioInputPort _inputPort;
    private readonly ISelectEstadoServicioPresenter _presenter;

    public SelectEstadoServicioController(ISelectEstadoServicioInputPort inputPort, ISelectEstadoServicioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<IReadOnlyList<SelectEstadoServicioViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectEstadoServicioViewModel;
    }
}