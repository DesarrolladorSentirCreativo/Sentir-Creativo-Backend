using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Update;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.EstadoServicios
{
    public interface IUpdateEstadoServicioPresenter : IUpdateEstadoServicioOutputPort
    {
        int EstadoServicioId { get; }
    }
}
