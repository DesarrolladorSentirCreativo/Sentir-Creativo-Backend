using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Previsiones;

public class DeletePrevisionController : IDeletePrevisionController
{
    private readonly IDeletePrevisionInputPort _inputPort;
    private readonly IDeletePrevisionPresenter  _presenter;
    
    public DeletePrevisionController(
        IDeletePrevisionInputPort inputPort,
        IDeletePrevisionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int previsionId)
    {
        await _inputPort.Handle(previsionId);
        
        return _presenter.PrevisionId;
    }
}