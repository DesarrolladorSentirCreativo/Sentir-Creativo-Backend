namespace Sentir_Creativo_Backend.Servicios.Presenters.Ocacions
{
    public class SelectOcacionPresenter : ISelectOcacionPresenter
    {
        public IReadOnlyList<SelectOcacionModelView> ModelViews { get; private set; }

        public ValueTask Handle(IReadOnlyList<SelectOcacionModelView> modelViews)
        {
            ModelViews = modelViews;

            return ValueTask.CompletedTask;
        }
    }
}
