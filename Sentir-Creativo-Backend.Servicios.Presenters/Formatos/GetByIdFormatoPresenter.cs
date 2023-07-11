namespace Sentir_Creativo_Backend.Servicios.Presenters.Formatos
{
    public class GetByIdFormatoPresenter : IGetByIdFormatoPresenter
    {
        public GetByIdFormatoViewModel ViewModel { get; private set; }

        public ValueTask Handle(GetByIdFormatoViewModel viewModel)
        {
            ViewModel = viewModel;

            return ValueTask.CompletedTask;
        }
    }
}
