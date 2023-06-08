using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;

public interface ISelectRolPresenter : ISelectRolOutputPort
{
    IReadOnlyList<SelectRolViewModel> ModelViews { get; }
}