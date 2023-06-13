using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;

public interface IGetAllModoTrabajoPresenter : IGetAllModoTrabajoOutputPort
{
    IReadOnlyList<GetAllModoTrabajoViewModel> ModelViews { get; }
}