using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Login
{
    public interface ILoginUsuarioAdminOutputPort
    {
        ValueTask Handle(LoginUsuarioAdminViewModel viewModel);
    }
}
