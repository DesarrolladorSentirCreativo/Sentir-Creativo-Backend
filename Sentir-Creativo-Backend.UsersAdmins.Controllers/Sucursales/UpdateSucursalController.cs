using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Sucursales;

public class UpdateSucursalController : IUpdateSucursalController
{
    private readonly IUpdateSucursalInputPort _inputPort;
    private readonly IUpdateSucursalPresenter _presenter;
    
    public UpdateSucursalController(
        IUpdateSucursalInputPort inputPort, 
        IUpdateSucursalPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    public async ValueTask<int> Handle(UpdateSucursalDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.SucursalId;
    }
}