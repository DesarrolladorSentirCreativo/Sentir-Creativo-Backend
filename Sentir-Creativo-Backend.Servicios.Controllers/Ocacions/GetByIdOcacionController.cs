namespace Sentir_Creativo_Backend.Servicios.Controllers.Ocacions
{
    public class GetByIdOcacionController : IGetByIdOcacionController
    {

        private readonly IGetByIdOcacionPresenter _presenter;
        private readonly IGetByIdOcacionInputPort _inputPort;

        public GetByIdOcacionController(
            IGetByIdOcacionPresenter presenter, 
            IGetByIdOcacionInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<GetByIdOcacionViewModel> Handle(int ocacionId)
        {
            await _inputPort.Handle(ocacionId);

            return _presenter.ViewModel;
        }
    }
}
