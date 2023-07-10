namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.EstadoServicios
{
    public interface IGetByIdEstadoServicioPresenter : IGetByIdEstadoServicioOutputPort
    {
        GetByIdEstadoServicioViewModel ViewModel { get; }
    }
}
