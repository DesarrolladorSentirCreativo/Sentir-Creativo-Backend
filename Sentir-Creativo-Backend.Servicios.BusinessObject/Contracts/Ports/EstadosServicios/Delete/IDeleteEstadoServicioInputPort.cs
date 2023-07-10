namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Delete
{
    public interface IDeleteEstadoServicioInputPort
    {
        ValueTask Handle(int estadoServicioId);
    }
}
