using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Controllers;

public interface ISelectCuponDescuentoController
{
    ValueTask<IReadOnlyList<SelectCuponDescuentoViewModel>> Handle();
}