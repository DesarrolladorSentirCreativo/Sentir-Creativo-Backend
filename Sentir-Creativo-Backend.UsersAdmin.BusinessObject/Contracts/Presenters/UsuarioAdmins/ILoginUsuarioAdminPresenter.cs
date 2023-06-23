using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins
{
    public interface ILoginUsuarioAdminPresenter : ILoginUsuarioAdminOutputPort
    {
        LoginUsuarioAdminViewModel ViewModel { get; }
    }
}
