namespace Sentir_Creativo_Backend.Servicios.Presenters.Ocacions
{
    public class GetAllOcacionPresenter : IGetAllOcacionPresenter
    {
        public IReadOnlyList<GetAllOcacionViewModel> ViewModels { get; private set; }

        public ValueTask Handle(IReadOnlyList<GetAllOcacionViewModel> viewModels)
        {
            ViewModels = viewModels;

            return ValueTask.CompletedTask;
        }
    }
}
