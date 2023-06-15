using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.UsuarioAdmins;

public class CreateUsuarioAdminController : ICreateUsuarioAdminController
{
    private readonly ICreateUsuarioAdminInputPort _inputPort;
    private readonly ICreateUsuarioAdminPresenter _presenter;
    
    public CreateUsuarioAdminController(
        ICreateUsuarioAdminInputPort inputPort,
        ICreateUsuarioAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateUsuarioAdminDto dto)
    {
        await _inputPort.Handle(dto);
        
        return _presenter.UsuarioAdminId;
    }
}