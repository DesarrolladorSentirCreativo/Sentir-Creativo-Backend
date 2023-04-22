using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.EstadoAudiencias.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.EstadoAudiencias;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.EstadoAudiencias;

public class SelectEstadoAudienciaController : ISelectEstadoAudienciaController
{
    private readonly ISelectEstadoAudienciaInputPort _inputPort;
    private readonly ISelectEstadoAudienciaPresenter _presenter;

    public SelectEstadoAudienciaController(
        ISelectEstadoAudienciaInputPort inputPort,
        ISelectEstadoAudienciaPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<IReadOnlyList<SelectEstadoAudienciaViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectEstadoAudienciaViewModel;
    }
}