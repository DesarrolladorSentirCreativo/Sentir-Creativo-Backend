namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Update
{
    public interface IUpdateEstadoServicioInputPort
    {
        ValueTask Handle(UpdateEstadoServicioDto dto);
    }
}
