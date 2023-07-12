namespace Sentir_Creativo_Backend.PublicoObjetivos.Controllers.PublicoObjetivos
{
    public class DeletePublicoObjetivoController : IDeletePublicoObjetivoController
    {

        private readonly IDeletePublicoObjetivoInputPort _inputPort;
        private readonly IDeletePublicoObjetivoPresenter _presenter;

        public DeletePublicoObjetivoController(
            IDeletePublicoObjetivoInputPort inputPort,
            IDeletePublicoObjetivoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<int> Handle(int publicoObjetivoId)
        {
            await _inputPort.Handle(publicoObjetivoId);

            return _presenter.PublicoObjetivoId;
        }
    }
}
