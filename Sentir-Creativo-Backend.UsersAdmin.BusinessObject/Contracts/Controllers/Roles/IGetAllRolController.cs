using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;

public interface IGetAllRolController
{
    ValueTask<IReadOnlyList<GetAllRolViewModel>> Handle();
}