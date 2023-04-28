using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Regiones;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Regiones;

public interface ISelectRegionController
{
    ValueTask<IReadOnlyList<SelectRegionViewModel>> Handle();
}