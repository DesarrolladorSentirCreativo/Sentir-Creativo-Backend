namespace Sentir_Creativo_Backend.Servicios.Presenters.EstadoServicios
{
    public class CreateEstadoServicioPresenter : ICreateEstadoServicioPresenter
    {
        public int EstadoServicioId { get; private set; }

        public ValueTask Handle(int estadoServicioId)
        {
            EstadoServicioId = estadoServicioId;

            return ValueTask.CompletedTask;
        }
    }
}
