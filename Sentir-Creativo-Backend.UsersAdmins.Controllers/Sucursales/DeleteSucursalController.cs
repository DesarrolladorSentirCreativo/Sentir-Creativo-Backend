using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Sucursales;

public class DeleteSucursalController : IDeleteSucursalController
{
    private readonly IDeleteSucursalInputPort _inputPort;
    private readonly IDeleteSucursalPresenter _presenter;
    
    public DeleteSucursalController(
        IDeleteSucursalPresenter presenter,
        IDeleteSucursalInputPort inputPort)
    {
        _presenter = presenter;
        _inputPort = inputPort;
    }
    
    public async ValueTask<int> Handle(int sucursalId)
    {
        await _inputPort.Handle(sucursalId);
        return _presenter.SucursalId;
    }
}