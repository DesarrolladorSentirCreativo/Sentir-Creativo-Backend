namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios
{
    public interface IUpdateEstadoServicioController
    {
        ValueTask<int> Handle(UpdateEstadoServicioDto dto);
    }
}
