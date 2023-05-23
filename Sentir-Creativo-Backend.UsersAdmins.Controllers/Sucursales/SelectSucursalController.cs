using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Sucursales;

public class SelectSucursalController : ISelectSucursalController
{
    private readonly ISelectSucursalInputPort _inputPort;
    private readonly ISelectSucursalPresenter _presenter;
    
    public SelectSucursalController(
        ISelectSucursalInputPort inputPort,
        ISelectSucursalPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectSucursalViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}