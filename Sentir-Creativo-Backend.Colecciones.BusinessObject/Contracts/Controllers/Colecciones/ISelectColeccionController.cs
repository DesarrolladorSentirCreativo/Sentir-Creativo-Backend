using Sentir_Creativo_Backend.Colecciones.BusinessObject.ViewModels.Colecciones;

namespace Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Controllers.Colecciones;

public interface ISelectColeccionController
{
    ValueTask<IReadOnlyList<SelectColeccionViewModel>> Handle();
}