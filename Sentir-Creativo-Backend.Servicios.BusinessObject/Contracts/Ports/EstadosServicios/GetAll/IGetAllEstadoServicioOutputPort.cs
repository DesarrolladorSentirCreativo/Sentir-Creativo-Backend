namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.GetAll
{
    public interface IGetAllEstadoServicioOutputPort
    {
        ValueTask Handle(IReadOnlyList<GetAllEstadoServicioViewModel> viewModels);
    }
}
