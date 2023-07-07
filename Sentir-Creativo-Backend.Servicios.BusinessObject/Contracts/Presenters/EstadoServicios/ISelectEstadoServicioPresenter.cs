namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.EstadoServicios;

public interface ISelectEstadoServicioPresenter : ISelectEstadoServicioOutputPort
{
    IReadOnlyList<SelectEstadoServicioViewModel> SelectEstadoServicioViewModel { get; }
}