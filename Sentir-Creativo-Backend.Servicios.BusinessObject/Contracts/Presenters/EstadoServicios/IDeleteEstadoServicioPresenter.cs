namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.EstadoServicios
{
    public interface IDeleteEstadoServicioPresenter : IDeleteEstadoServicioOutputPort
    {
        int EstadoServicioId { get; }
    }
}
