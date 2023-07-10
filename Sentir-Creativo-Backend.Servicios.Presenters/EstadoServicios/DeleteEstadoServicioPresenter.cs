namespace Sentir_Creativo_Backend.Servicios.Presenters.EstadoServicios
{
    public class DeleteEstadoServicioPresenter : IDeleteEstadoServicioPresenter
    {
        public int EstadoServicioId { get; private set; }

        public ValueTask Handle(int estadoServicioId)
        {
            EstadoServicioId = estadoServicioId;

            return ValueTask.CompletedTask;
        }
    }
}
