using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.EstadoUserAdmins;

public class SelectEstadoUserAdminController : ISelectEstadoUserAdminController
{
    private readonly ISelectEstadoUserAdminInputPort _inputPort;
    private readonly ISelectEstadoUserAdminPresenter  _presenter;
    
    public SelectEstadoUserAdminController(
        ISelectEstadoUserAdminInputPort inputPort, ISelectEstadoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    
    public async ValueTask<IReadOnlyList<SelectEstadoUserAdminViewModel>> Handle()
    {
        await _inputPort.Handle();
        
        return _presenter.ViewModels;
    }
}