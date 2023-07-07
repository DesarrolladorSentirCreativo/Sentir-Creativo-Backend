namespace Sentir_Creativo_Backend.Servicios.Controllers.Ocacions
{
    public class DeleteOcacionController : IDeleteOcacionController
    {

        private readonly IDeleteOcacionPresenter _presenter;
        private readonly IDeleteOcacionInputPort _inputPort;

        public DeleteOcacionController(IDeleteOcacionPresenter presenter, IDeleteOcacionInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<int> Handle(int ocacionId)
        {
            await _inputPort.Handle(ocacionId);

            return _presenter.OcacionId;
        }
    }
}
