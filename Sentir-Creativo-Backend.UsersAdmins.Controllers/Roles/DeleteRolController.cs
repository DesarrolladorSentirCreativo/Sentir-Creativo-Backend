using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Roles;

public class DeleteRolController : IDeleteRolController
{
    private readonly IDeleteRolInputPort _inputPort;
    private readonly IDeleteRolPresenter  _presenter;
    
    public DeleteRolController(IDeleteRolInputPort inputPort, IDeleteRolPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int rolId)
    {
        await _inputPort.Handle(rolId);
        return _presenter.RolId;
    }
}