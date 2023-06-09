namespace Sentir_Creativo_Backend.PublicoObjetivos.Presenters.PublicoObjetivos;

public class SelectPublicoObjetivoPresenter : ISelectPublicoObjetivoPresenter
{
    public IReadOnlyList<SelectPublicoObjetivoViewModel> SelectPublicoObjetivoViewModel { get; private set; }

    public ValueTask Handle(IReadOnlyList<SelectPublicoObjetivoViewModel> modelView)
    {
        SelectPublicoObjetivoViewModel  = modelView;

        return ValueTask.CompletedTask;
    }
}