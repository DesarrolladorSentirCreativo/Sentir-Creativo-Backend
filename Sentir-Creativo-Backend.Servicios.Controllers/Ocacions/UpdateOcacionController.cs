namespace Sentir_Creativo_Backend.Servicios.Controllers.Ocacions
{


    public class UpdateOcacionController : IUpdateOcacionController
    {    

        private readonly IUpdateOcacionPresenter _presenter;
        private readonly IUpdateOcacionInputPort _inputPort;

        public UpdateOcacionController(
            IUpdateOcacionPresenter presenter, 
            IUpdateOcacionInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<int> Handle(UpdateOcacionDto dto)
        {
            await _inputPort.Handle(dto);
            return _presenter.OcacionId;
        }
    }
}
