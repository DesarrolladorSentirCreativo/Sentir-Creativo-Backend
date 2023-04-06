using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Motivaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Motivaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Motivaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Motivaciones;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Motivaciones;

public class SelectMotivacionController : ISelectMotivacionController
{
    private readonly ISelectMotivacionInputPort _inputPort;
    private readonly ISelectMotivacionPresenter _presenter;
    
    public SelectMotivacionController(ISelectMotivacionInputPort inputPort, ISelectMotivacionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectMotivacionViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectMotivacionViewModel;
    }
}