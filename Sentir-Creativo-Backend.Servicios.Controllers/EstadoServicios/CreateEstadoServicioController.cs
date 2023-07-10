namespace Sentir_Creativo_Backend.Servicios.Controllers.EstadoServicios
{
    public class CreateEstadoServicioController : ICreateEstadoServicioController
    {
        private readonly ICreateEstadoServicioInputPort _inputPort;
        private readonly ICreateEstadoServicioPresenter _presenter;

        public CreateEstadoServicioController(
            ICreateEstadoServicioInputPort inputPort, 
            ICreateEstadoServicioPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        
        public async ValueTask<int> Handle(CreateEstadoServicioDto dto)
        {
            await _inputPort.Handle(dto);

            return _presenter.EstadoServicioId;
        }
    }
}
