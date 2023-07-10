namespace Sentir_Creativo_Backend.Servicios.Controllers.EstadoServicios
{
    public class GetAllEstadoServicioController : IGetAllEstadoServicioController
    {
           
        private readonly IGetAllEstadoServicioInputPort _inputPort;
        private readonly IGetAllEstadoServicioPresenter _presenter;

        public GetAllEstadoServicioController(
            IGetAllEstadoServicioInputPort inputPort,
            IGetAllEstadoServicioPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<IReadOnlyList<GetAllEstadoServicioViewModel>> Handle()
        {
            await _inputPort.Handle();

            return _presenter.ViewModels;
        }
    }
}
