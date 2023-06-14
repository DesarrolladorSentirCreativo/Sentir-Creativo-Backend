using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.EstadoUserAdmins;

public class GetByIdEstadoUserAdminController : IGetByIdEstadoUserAdminController
{
    private readonly IGetByIdEstadoUserAdminInputPort _inputPort;
    private readonly IGetByIdEstadoUserAdminPresenter  _presenter;
    
    public GetByIdEstadoUserAdminController(
        IGetByIdEstadoUserAdminInputPort inputPort, IGetByIdEstadoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdEstadoUserAdminViewModel> Handle(int estadoId)
    {
        await _inputPort.Handle(estadoId);
        
        return _presenter.ViewModel;
    }
}