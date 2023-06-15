using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;

public interface IGetAllUsuarioAdminController
{
    ValueTask<IReadOnlyList<GetAllUsuarioAdminViewModel>> Handle();
}