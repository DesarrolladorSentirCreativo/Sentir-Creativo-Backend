using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins
{
    public interface ILoginUsuarioAdminController
    {
        ValueTask<LoginUsuarioAdminViewModel> Handle(LoginUsuarioAdminDto dto);
    }
}
