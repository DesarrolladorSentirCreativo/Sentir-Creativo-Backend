using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Roles;

public class UpdateRolController : IUpdateRolController
{
    private readonly IUpdateRolInputPort _inputPort;
    private readonly IUpdateRolPresenter  _presenter;

    public UpdateRolController(IUpdateRolInputPort inputPort, IUpdateRolPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<int> Handle(UpdateRolDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.RolId;
    }
}