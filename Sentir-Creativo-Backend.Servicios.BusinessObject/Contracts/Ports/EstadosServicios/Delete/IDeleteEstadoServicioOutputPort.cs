namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Delete
{
    public interface IDeleteEstadoServicioOutputPort
    {
        ValueTask Handle(int estadoServicioId);
    }
}
