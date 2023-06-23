using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.UsuarioAdmins
{
    public class LoginUsuarioAdminController : ILoginUsuarioAdminController
    {

        private readonly ILoginUsuarioAdminInputPort _inputPort;
        private readonly ILoginUsuarioAdminPresenter _presenter;

        public LoginUsuarioAdminController(
            ILoginUsuarioAdminInputPort inputPort,
            ILoginUsuarioAdminPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<LoginUsuarioAdminViewModel> Handle(LoginUsuarioAdminDto dto)
        {
            await _inputPort.Handle(dto);

            return _presenter.ViewModel;
        }
    }
}
