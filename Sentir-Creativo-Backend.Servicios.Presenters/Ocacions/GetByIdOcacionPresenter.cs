namespace Sentir_Creativo_Backend.Servicios.Presenters.Ocacions
{
    public class GetByIdOcacionPresenter : IGetByIdOcacionPresenter
    {
        public GetByIdOcacionViewModel ViewModel { get; private set; }

        public ValueTask Handle(GetByIdOcacionViewModel viewModel)
        {
            ViewModel = viewModel;

            return ValueTask.CompletedTask;
        }
    }
}
