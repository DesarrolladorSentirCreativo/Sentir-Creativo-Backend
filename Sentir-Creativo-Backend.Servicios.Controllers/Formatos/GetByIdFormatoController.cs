namespace Sentir_Creativo_Backend.Servicios.Controllers.Formatos
{
    public class GetByIdFormatoController : IGetByIdFormatoController
    {
        private readonly IGetByIdFormatoInputPort _inputPort;
        private readonly IGetByIdFormatoPresenter _presenter;

        public GetByIdFormatoController(IGetByIdFormatoInputPort inputPort, IGetByIdFormatoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<GetByIdFormatoViewModel> Handle(int formatoId)
        {
            await _inputPort.Handle(formatoId);

            return _presenter.ViewModel;
        }
    }
}
