using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.EstadoServicios;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Select;

public interface ISelectEstadoServicioOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectEstadoServicioViewModel> modelView);
}