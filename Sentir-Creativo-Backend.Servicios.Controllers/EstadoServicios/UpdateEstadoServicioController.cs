namespace Sentir_Creativo_Backend.Servicios.Controllers.EstadoServicios
{
    public class UpdateEstadoServicioController : IUpdateEstadoServicioController
    {
        private readonly IUpdateEstadoServicioInputPort _inputPort;
        private readonly IUpdateEstadoServicioPresenter _presenter;

        public UpdateEstadoServicioController(
            IUpdateEstadoServicioInputPort inputPort, 
            IUpdateEstadoServicioPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<int> Handle(UpdateEstadoServicioDto dto)
        {
            await _inputPort.Handle(dto);

            return _presenter.EstadoServicioId;
        }
    }
}
