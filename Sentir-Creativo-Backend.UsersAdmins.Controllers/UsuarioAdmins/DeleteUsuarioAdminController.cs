using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.UsuarioAdmins;

public class DeleteUsuarioAdminController : IDeleteUsuarioAdminController
{
    private readonly IDeleteUsuarioAdminInputPort _inputPort;
    private readonly IDeleteUsuarioAdminPresenter _presenter;
    
    public DeleteUsuarioAdminController(
        IDeleteUsuarioAdminInputPort inputPort,
        IDeleteUsuarioAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int usuarioAdminId)
    {
        await _inputPort.Handle(usuarioAdminId);

        return _presenter.UsuarioAdminId;
    }
}