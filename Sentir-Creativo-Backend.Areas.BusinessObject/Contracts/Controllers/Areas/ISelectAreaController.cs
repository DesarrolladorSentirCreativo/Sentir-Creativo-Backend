using Sentir_Creativo_Backend.Areas.BusinessObject.ViewModels.Areas;

namespace Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Controllers.Areas;

public interface ISelectAreaController
{
    ValueTask<IReadOnlyList<SelectAreaViewModel>> Handle();
}