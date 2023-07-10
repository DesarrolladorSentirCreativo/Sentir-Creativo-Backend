namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.EstadoServicios
{
    public interface IGetAllEstadoServicioPresenter : IGetAllEstadoServicioOutputPort
    {
        IReadOnlyList<GetAllEstadoServicioViewModel> ViewModels { get; }
    }
}
