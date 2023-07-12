namespace Sentir_Creativo_Backend.PublicoObjetivos.Controllers.PublicoObjetivos;

public class SelectPublicoObjetivoController : ISelectPublicoObjetivoController
{
    private readonly ISelectPublicoObjetivoInputPort _inputPort;
    private readonly ISelectPublicoObjetivoPresenter _presenter;
    
    public SelectPublicoObjetivoController(ISelectPublicoObjetivoInputPort inputPort, ISelectPublicoObjetivoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectPublicoObjetivoViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectPublicoObjetivoViewModel;
    }
}