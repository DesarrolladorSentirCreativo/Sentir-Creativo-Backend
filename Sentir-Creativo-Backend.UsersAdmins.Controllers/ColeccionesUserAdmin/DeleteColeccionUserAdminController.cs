using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ColeccionesUserAdmin;

public class DeleteColeccionUserAdminController : IDeleteColeccionUserAdminController
{
    private readonly IDeleteColeccionUserAdminInputPort _inputPort;
    private readonly IDeleteColeccionUserAdminPresenter _presenter;
    
    public DeleteColeccionUserAdminController(
        IDeleteColeccionUserAdminPresenter presenter,
        IDeleteColeccionUserAdminInputPort inputPort)
    {
        _presenter = presenter;
        _inputPort = inputPort;
    }
    
    public async  ValueTask<int> Handle(int coleccionUserAdminId)
    {
        await _inputPort.Handle(coleccionUserAdminId);
        return _presenter.ColeccionUserAdminId;
    }
}