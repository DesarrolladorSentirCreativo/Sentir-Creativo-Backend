namespace Sentir_Creativo_Backend.Servicios.Presenters.EstadoServicios
{
    public class GetAllEstadoServicioPresenter : IGetAllEstadoServicioPresenter
    {
        public IReadOnlyList<GetAllEstadoServicioViewModel> ViewModels { get; private set; }

        public ValueTask Handle(IReadOnlyList<GetAllEstadoServicioViewModel> viewModels)
        {
            ViewModels = viewModels;

            return ValueTask.CompletedTask;
        }
    }
}
