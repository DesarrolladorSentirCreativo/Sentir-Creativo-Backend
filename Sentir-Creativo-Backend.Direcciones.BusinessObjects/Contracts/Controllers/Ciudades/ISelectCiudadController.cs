using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Ciudades;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Ciudades;

public interface ISelectCiudadController
{
    ValueTask<IReadOnlyList<SelectCiudadViewModel>> Handle();
}