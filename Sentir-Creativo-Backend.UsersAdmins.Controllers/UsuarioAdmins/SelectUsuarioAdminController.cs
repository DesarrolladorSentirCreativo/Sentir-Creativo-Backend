using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.UsuarioAdmins;

public class SelectUsuarioAdminController : ISelectUsuarioAdminController
{
    private readonly ISelectUsuarioAdminInputPort _inputPort;
    private readonly ISelectUsuarioAdminPresenter _presenter;
    
    public SelectUsuarioAdminController(
        ISelectUsuarioAdminInputPort inputPort,
        ISelectUsuarioAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectUsuarioAdminViewModel>> Handle()
    {
        await _inputPort.Handle();

        return _presenter.ViewModels;
    }
}