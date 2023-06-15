using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.UsuarioAdmins;

public class UpdateUsuarioAdminController : IUpdateUsuarioAdminController
{
    private readonly IUpdateUsuarioAdminInputPort _inputPort;
    private readonly IUpdateUsuarioAdminPresenter _presenter;
    
    public UpdateUsuarioAdminController(
        IUpdateUsuarioAdminInputPort inputPort,
        IUpdateUsuarioAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(UpdateUsuarioAdminDto dto)
    { 
        await _inputPort.Handle(dto);
        
        return _presenter.UsuarioAdminId;
    }
}