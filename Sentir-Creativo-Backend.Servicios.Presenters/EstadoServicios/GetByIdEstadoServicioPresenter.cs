namespace Sentir_Creativo_Backend.Servicios.Presenters.EstadoServicios
{
    public class GetByIdEstadoServicioPresenter : IGetByIdEstadoServicioPresenter
    {
        public GetByIdEstadoServicioViewModel ViewModel { get; private set; }

        public ValueTask Handle(GetByIdEstadoServicioViewModel viewModel)
        {
            ViewModel = viewModel;

            return ValueTask.CompletedTask;
        }
    }
}
