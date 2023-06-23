using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.UsuarioAdmins
{
    public class LoginUsuarioAdminPresenter : ILoginUsuarioAdminPresenter
    {
        public LoginUsuarioAdminViewModel ViewModel { get; private set; }

        public ValueTask Handle(LoginUsuarioAdminViewModel viewModel)
        {
            ViewModel = viewModel;

            return ValueTask.CompletedTask;
        }
    }
}
