using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Origenes;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Origenes.SelectOrigen;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Origenes;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Origenes;

public class SelectOrigenController : ISelectOrigenController
{
    private readonly ISelectOrigenInputPort _inputPort;
    private readonly ISelectOrigenPresenter _presenter;

    public SelectOrigenController(ISelectOrigenInputPort inputPort, ISelectOrigenPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectOrigenViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectOrigenViewModel;
    }
}