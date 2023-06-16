using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.UsuarioAdmins;

public class GetByIdUsuarioAdminController : IGetByIdUsuarioAdminController
{
    private readonly IGetByIdUsuarioAdminInputPort _inputPort;
    private readonly IGetByIdUsuarioAdminPresenter _presenter;
    
    public GetByIdUsuarioAdminController(
        IGetByIdUsuarioAdminInputPort inputPort,
        IGetByIdUsuarioAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdUsuarioAdminViewModel> Handle(int usuarioAdminId)
    {
        await _inputPort.Handle(usuarioAdminId);

        return _presenter.ViewModel;
    }
}