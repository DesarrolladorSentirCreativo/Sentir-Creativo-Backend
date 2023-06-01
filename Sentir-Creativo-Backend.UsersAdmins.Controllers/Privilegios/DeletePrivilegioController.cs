using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Privilegios;

public class DeletePrivilegioController : IDeletePrivilegioController
{
    private readonly IDeletePrivilegioInputPort _inputPort;
    private readonly IDeletePrivilegioPresenter  _presenter;

    public DeletePrivilegioController(
        IDeletePrivilegioInputPort inputPort,
        IDeletePrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<string> Handle(string privilegioId)
    {
        await _inputPort.Handle(privilegioId);
        return _presenter.PrivilegioId;
    }
}