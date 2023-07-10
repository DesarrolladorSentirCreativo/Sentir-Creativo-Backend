namespace Sentir_Creativo_Backend.Servicios.Presenters.Formatos
{
    public class GetAllFormatoPresenter : IGetAllFormatoPresenter
    {
        public IReadOnlyList<GetAllFormatoViewModel> ViewModels { get; private set; }

        public ValueTask Handle(IReadOnlyList<GetAllFormatoViewModel> viewModels)
        {
            ViewModels = viewModels;

            return ValueTask.CompletedTask;
        }
    }
}
