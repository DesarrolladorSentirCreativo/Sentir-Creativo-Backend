using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Roles;

public class CreateRolController : ICreateRolController
{
    private readonly ICreateRolInputPort _inputPort;
    private readonly ICreateRolPresenter  _presenter;
    
    public CreateRolController(
        ICreateRolInputPort inputPort,
        ICreateRolPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateRolDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.RolId;
    }
}