namespace Sentir_Creativo_Backend.Servicios.Controllers.Ocacions
{
    public class SelectOcacionController : ISelectOcacionController
    {
        private readonly ISelectOcacionPresenter _presenter;
        private readonly ISelectOcacionInputPort _inputPort;

        public SelectOcacionController(
            ISelectOcacionPresenter presenter,
            ISelectOcacionInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<IReadOnlyList<SelectOcacionModelView>> Handle()
        {
            await _inputPort.Handle();

            return _presenter.ModelViews;
        }
    }
}
