namespace Sentir_Creativo_Backend.PublicoObjetivos.Controllers.PublicoObjetivos
{
    public class CreatePublicoObjetivoController : ICreatePublicoObjetivoController
    {
        private readonly ICreatePublicoObjetivoInputPort _inputPort;
        private readonly ICreatePublicoObjetivoPresenter _presenter;

        public CreatePublicoObjetivoController(
            ICreatePublicoObjetivoInputPort inputPort,
            ICreatePublicoObjetivoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<int> Handle(CreatePublicoObjetivoDto dto)
        {
            await _inputPort.Handle(dto);

            return _presenter.PublicoObjetivoId;
        }
    }
}
