using Sentir_Creativo_Backend.Difusiones.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Difusiones.BusinessObject.Controllers;

public interface ISelectDifusionController
{
    ValueTask<IReadOnlyList<SelectDifusionViewModel>> Handle();
}