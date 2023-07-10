namespace Sentir_Creativo_Backend.Servicios.Controllers.EstadoServicios
{
    public class DeleteEstadoServicioController : IDeleteEstadoServicioController
    {
        private readonly IDeleteEstadoServicioInputPort _inputPort;
        private readonly IDeleteEstadoServicioPresenter _presenter;

        public DeleteEstadoServicioController(
            IDeleteEstadoServicioInputPort inputPort, 
            IDeleteEstadoServicioPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<int> Handle(int estadoServicioId)
        {
            await _inputPort.Handle(estadoServicioId);

            return _presenter.EstadoServicioId;
        }
    }
}
