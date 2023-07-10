namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.GetById
{
    public interface IGetByIdEstadoServicioInputPort
    {
        ValueTask Handle(int estadoServicioId);
    }
}
