using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.EstadoUserAdmins;

public class DeleteEstadoUserAdminController : IDeleteEstadoUserAdminController
{
    private readonly IDeleteEstadoUserAdminInputPort _inputPort;
    private readonly IDeleteEstadoUserAdminPresenter  _presenter;
    
    public DeleteEstadoUserAdminController(
        IDeleteEstadoUserAdminInputPort inputPort, IDeleteEstadoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int estadoId)
    {
        await _inputPort.Handle(estadoId);
        
        return _presenter.EstadoId;
    }
}