namespace Sentir_Creativo_Backend.PublicoObjetivos.Controllers.PublicoObjetivos
{
    public class GetAllPublicoObjetivoController : IGetAllPublicoObjetivoController
    {
        private readonly IGetAllPublicoObjetivoInputPort _inputPort;
        private readonly IGetAllPublicoObjetivoPresenter _presenter;

        public GetAllPublicoObjetivoController(IGetAllPublicoObjetivoInputPort inputPort, IGetAllPublicoObjetivoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<IReadOnlyList<GetAllPublicoObjetivoViewModel>> Handle()
        {
            await _inputPort.Handle();

            return _presenter.ModelViews;
        }
    }
}
