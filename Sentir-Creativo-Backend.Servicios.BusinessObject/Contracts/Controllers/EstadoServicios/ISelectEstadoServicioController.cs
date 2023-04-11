using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.EstadoServicios;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios;

public interface ISelectEstadoServicioController
{
    ValueTask<IReadOnlyList<SelectEstadoServicioViewModel>> Handle();
}