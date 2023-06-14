using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.EstadoUserAdmins;

public class GetAllEstadoUserAdminController : IGetAllEstadoUserAdminController
{
    private readonly IGetAllEstadoUserAdminInputPort _inputPort;
    private readonly IGetAllEstadoUserAdminPresenter  _presenter;
    
    public GetAllEstadoUserAdminController(
        IGetAllEstadoUserAdminInputPort inputPort, IGetAllEstadoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<GetAllEstadoUserAdminViewModel>> Handle()
    {
        await _inputPort.Handle();
        
        return _presenter.ViewModels;
    }
}