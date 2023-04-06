using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Prefijos;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Prefijos.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Prefijos;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Prefijos;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Prefijos;

public class SelectPrefijoController : ISelectPrefijoController
{
    private readonly ISelectPrefijoInputPort _inputPort;
    private readonly ISelectPrefijoPresenter _presenter;

    public SelectPrefijoController(ISelectPrefijoInputPort inputPort, ISelectPrefijoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectPrefijoViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectPrefijoViewModel;
    }
}