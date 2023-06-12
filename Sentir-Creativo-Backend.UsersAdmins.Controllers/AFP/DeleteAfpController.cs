using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AFP;

public class DeleteAfpController : IDeleteAfpController
{
    private readonly IDeleteAfpInputPort _inputPort;
    private readonly IDeleteAfpPresenter  _presenter;
    
    public DeleteAfpController(IDeleteAfpInputPort inputPort, IDeleteAfpPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int afpId)
    {
         await _inputPort.Handle(afpId);
         return _presenter.AfpId;
    }
}