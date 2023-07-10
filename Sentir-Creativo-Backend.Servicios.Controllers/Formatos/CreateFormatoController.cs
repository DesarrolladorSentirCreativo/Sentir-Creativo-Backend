namespace Sentir_Creativo_Backend.Servicios.Controllers.Formatos
{
    public class CreateFormatoController : ICreateFormatoController
    {
        private readonly ICreateFormatoInputPort _inputPort;
        private readonly ICreateFormatoPresenter _presenter;

        public CreateFormatoController(ICreateFormatoInputPort inputPort, ICreateFormatoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<int> Handle(CreateFormatoDto dto)
        {
            await _inputPort.Handle(dto);

            return _presenter.FormatoId;

        }
    }
}
