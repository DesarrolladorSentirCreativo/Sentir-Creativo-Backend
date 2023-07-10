namespace Sentir_Creativo_Backend.Servicios.Controllers.EstadoServicios
{
    public class GetByIdEstadoServicioController : IGetByIdEstadoServicioController
    {
        private readonly IGetByIdEstadoServicioInputPort _inputPort;
        private readonly IGetByIdEstadoServicioPresenter _presenter;

        public GetByIdEstadoServicioController(
            IGetByIdEstadoServicioInputPort inputPort,
            IGetByIdEstadoServicioPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<GetByIdEstadoServicioViewModel> Handle(int estadoServicioId)
        {
            await _inputPort.Handle(estadoServicioId);

            return _presenter.ViewModel;
        }
    }
}
