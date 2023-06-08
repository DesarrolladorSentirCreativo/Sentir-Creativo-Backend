using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Select;

public interface ISelectRolOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectRolViewModel> modelViews);
}