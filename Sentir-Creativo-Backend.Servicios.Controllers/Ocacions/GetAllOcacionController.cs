namespace Sentir_Creativo_Backend.Servicios.Controllers.Ocacions
{
    public class GetAllOcacionController : IGetAllOcacionController
    {

        private readonly IGetAllOcacionPresenter _presenter;
        private readonly IGetAllOcacionInputPort _inputPort;

        public GetAllOcacionController(IGetAllOcacionPresenter presenter, IGetAllOcacionInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<IReadOnlyList<GetAllOcacionViewModel>> Handle()
        {
            await _inputPort.Handle();

            return _presenter.ViewModels;
        }
    }
}
