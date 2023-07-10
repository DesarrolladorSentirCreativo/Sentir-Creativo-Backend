namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.GetById
{
    public interface IGetByIdEstadoServicioOutputPort
    {
        ValueTask Handle(GetByIdEstadoServicioViewModel viewModel);
    }
}
