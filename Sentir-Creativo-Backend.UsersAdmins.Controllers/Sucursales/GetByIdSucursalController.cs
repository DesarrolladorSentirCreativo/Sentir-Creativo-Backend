using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Sucursales;

public class GetByIdSucursalController : IGetByIdSucursalController
{
    private readonly IGetByIdSucursalInputPort _inputPort;
    private readonly IGetByIdSucursalPresenter _presenter;
    
    public GetByIdSucursalController(
        IGetByIdSucursalInputPort inputPort, 
        IGetByIdSucursalPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdSucursalViewModel> Handle(int sucursalId)
    {
        await _inputPort.Handle(sucursalId);
        return _presenter.ModelView;
    }
}