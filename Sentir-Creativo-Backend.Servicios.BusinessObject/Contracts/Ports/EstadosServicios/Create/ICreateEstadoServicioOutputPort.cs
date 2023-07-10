namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Create
{
    public interface ICreateEstadoServicioOutputPort
    {
        ValueTask Handle(int estadoServicioId);
    }
}
