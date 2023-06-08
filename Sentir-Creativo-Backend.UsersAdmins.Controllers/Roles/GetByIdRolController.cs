using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Roles;

public class GetByIdRolController : IGetByIdRolController
{
    private readonly IGetByIdRolInputPort _inputPort;
    private readonly IGetByIdRolPresenter  _presenter;
    
    public GetByIdRolController(
        IGetByIdRolInputPort inputPort,
        IGetByIdRolPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdRolViewModel> Handle(int rolId)
    {
        await _inputPort.Handle(rolId);
        return _presenter.ModelView;
    }
}