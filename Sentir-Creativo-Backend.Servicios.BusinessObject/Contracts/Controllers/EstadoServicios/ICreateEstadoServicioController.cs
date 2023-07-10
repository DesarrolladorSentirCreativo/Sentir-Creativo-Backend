namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios
{
    public interface ICreateEstadoServicioController
    {
        ValueTask<int> Handle(CreateEstadoServicioDto dto);
    }
}
