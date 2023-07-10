namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Update
{
    public interface IUpdateEstadoServicioOutputPort
    {
        ValueTask Handle(int estadoServicioId);
    }
}
