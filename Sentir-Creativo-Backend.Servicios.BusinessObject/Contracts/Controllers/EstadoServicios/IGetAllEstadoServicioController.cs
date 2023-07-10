namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios
{
    public interface IGetAllEstadoServicioController
    {
        ValueTask<IReadOnlyList<GetAllEstadoServicioViewModel>> Handle();
    }
}
