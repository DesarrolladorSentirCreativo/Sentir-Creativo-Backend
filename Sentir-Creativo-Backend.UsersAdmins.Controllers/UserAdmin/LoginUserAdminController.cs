using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.UserAdmin;

public class LoginUserAdminController : ILoginUserAdminController
{
    private readonly ILoginUserAdminInputPort _inputPort;
    private readonly ILoginUserAdminPresenter _presenter;

    public LoginUserAdminController(ILoginUserAdminInputPort inputPort, ILoginUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<UserAdminTokenViewModel> Handle(LoginUserAdminDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.UserAdminTokenViewModel;
    }
}