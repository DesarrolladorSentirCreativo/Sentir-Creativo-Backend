namespace Sentir_Creativo_Backend.Servicios.Controllers.Formatos
{
    public class GetAllFormatoController : IGetAllFormatoController
    {
        private readonly IGetAllFormatoInputPort _inputPort;
        private readonly IGetAllFormatoPresenter _presenter;

        public GetAllFormatoController(IGetAllFormatoInputPort inputPort, IGetAllFormatoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<IReadOnlyList<GetAllFormatoViewModel>> Handle()
        {
            await _inputPort.Handle();

            return _presenter.ViewModels;
        }
    }
}
