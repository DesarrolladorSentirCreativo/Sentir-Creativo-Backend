using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;

public interface ISelectModoTrabajoPresenter : ISelectModoTrabajoOutputPort
{
    IReadOnlyList<SelectModoTrabajoViewModel> ModelViews { get; }
}