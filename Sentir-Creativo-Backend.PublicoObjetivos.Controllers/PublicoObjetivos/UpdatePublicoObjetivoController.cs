namespace Sentir_Creativo_Backend.PublicoObjetivos.Controllers.PublicoObjetivos
{
    public class UpdatePublicoObjetivoController : IUpdatePublicoObjetivoController
    {
        private readonly IUpdatePublicoObjetivoInputPort _inputPort;
        private readonly IUpdatePublicoObjetivoPresenter _presenter;

        public UpdatePublicoObjetivoController(
            IUpdatePublicoObjetivoInputPort inputPort, 
            IUpdatePublicoObjetivoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<int> Handle(UpdatePublicoObjetivoDto dto)
        {
            await _inputPort.Handle(dto);

            return _presenter.PublicoObjetivoId;
        }
    }
}
