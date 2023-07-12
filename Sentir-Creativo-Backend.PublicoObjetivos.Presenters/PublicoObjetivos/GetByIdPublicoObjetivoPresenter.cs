namespace Sentir_Creativo_Backend.PublicoObjetivos.Presenters.PublicoObjetivos
{
    public class GetByIdPublicoObjetivoPresenter : IGetByIdPublicoObjetivoPresenter
    {
        public GetByIdPublicoObjetivoViewModel ViewModel { get; private set; }

        public ValueTask Handle(GetByIdPublicoObjetivoViewModel viewModel)
        {
            ViewModel = viewModel;

            return ValueTask.CompletedTask;
        }
    }
}
