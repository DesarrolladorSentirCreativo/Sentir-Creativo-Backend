namespace Sentir_Creativo_Backend.Servicios.Controllers.Formatos
{
    public class DeleteFormatoController : IDeleteFormatoController
    {
        private readonly IDeleteFormatoInputPort _inputPort;
        private readonly IDeleteFormatoPresenter _presenter;

        public DeleteFormatoController(IDeleteFormatoInputPort inputPort, IDeleteFormatoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<int> Handle(int formatoId)
        {
            await _inputPort.Handle(formatoId);

            return _presenter.FormatoId;
        }
    }
}
