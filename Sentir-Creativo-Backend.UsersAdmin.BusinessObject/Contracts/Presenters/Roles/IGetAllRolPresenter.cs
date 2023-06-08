using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;

public interface IGetAllRolPresenter : IGetAllRolOutputPort
{
    IReadOnlyList<GetAllRolViewModel> ModelViews { get; }
}