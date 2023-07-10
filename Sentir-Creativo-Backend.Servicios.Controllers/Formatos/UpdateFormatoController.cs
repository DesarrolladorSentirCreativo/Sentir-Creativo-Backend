namespace Sentir_Creativo_Backend.Servicios.Controllers.Formatos
{
    public class UpdateFormatoController : IUpdateFormatoController
    {
        private readonly IUpdateFormatoInputPort _inputPort;
        private readonly IUpdateFormatoPresenter _presenter;

        public UpdateFormatoController(IUpdateFormatoInputPort inputPort, IUpdateFormatoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<int> Handle(UpdateFormatoDto dto)
        {
            await _inputPort.Handle(dto);

            return _presenter.FormatoId;
        }
    }
}
