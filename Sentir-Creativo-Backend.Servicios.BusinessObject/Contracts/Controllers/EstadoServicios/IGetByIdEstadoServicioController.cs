namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios
{
    public interface IGetByIdEstadoServicioController
    {
        ValueTask<GetByIdEstadoServicioViewModel> Handle(int estadoServicioId);
    }
}
