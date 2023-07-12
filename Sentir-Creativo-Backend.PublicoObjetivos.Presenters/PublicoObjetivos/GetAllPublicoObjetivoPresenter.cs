namespace Sentir_Creativo_Backend.PublicoObjetivos.Presenters.PublicoObjetivos
{
    public class GetAllPublicoObjetivoPresenter : IGetAllPublicoObjetivoPresenter
    {
        public IReadOnlyList<GetAllPublicoObjetivoViewModel> ModelViews { get; private set; }

        public ValueTask Handle(IReadOnlyList<GetAllPublicoObjetivoViewModel> viewModels)
        {
            ModelViews = viewModels;

            return ValueTask.CompletedTask;
        }
    }
}
