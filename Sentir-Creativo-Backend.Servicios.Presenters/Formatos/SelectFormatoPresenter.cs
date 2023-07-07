namespace Sentir_Creativo_Backend.Servicios.Presenters.Formatos;

public class SelectFormatoPresenter : ISelectFormatoPresenter
{
    public IReadOnlyList<SelectFormatoViewModel> SelectFormatoViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectFormatoViewModel> modelView)
    {
        SelectFormatoViewModel = modelView;

        return ValueTask.CompletedTask;
    }
}