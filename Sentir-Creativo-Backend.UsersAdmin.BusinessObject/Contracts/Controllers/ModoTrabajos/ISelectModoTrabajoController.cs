using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;

public interface ISelectModoTrabajoController
{
    ValueTask<IReadOnlyList<SelectModoTrabajoViewModel>> Handle();
}