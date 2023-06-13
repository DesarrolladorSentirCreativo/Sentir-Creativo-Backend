using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ModoTrabajos;

public class DeleteModoTrabajoController : IDeleteModoTrabajoController
{
    private readonly IDeleteModoTrabajoInputPort _inputPort;
    private readonly IDeleteModoTrabajoPresenter  _presenter;
    
    public DeleteModoTrabajoController(
        IDeleteModoTrabajoInputPort inputPort,
        IDeleteModoTrabajoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int modoTrabajoId)
    {
        await _inputPort.Handle(modoTrabajoId);
        
        return _presenter.ModoTrabajoId;
    }
}