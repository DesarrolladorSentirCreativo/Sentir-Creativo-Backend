namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Create
{
    public interface ICreateEstadoServicioInputPort 
    {
        ValueTask Handle(CreateEstadoServicioDto dto);
    }
}
