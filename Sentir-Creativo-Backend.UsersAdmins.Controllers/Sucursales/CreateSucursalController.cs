using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Sucursales;

public class CreateSucursalController : ICreateSucursalController
{
    private readonly ICreateSucursalInputPort _inputPort;
    private readonly ICreateSucursalPresenter _presenter;
    
    public CreateSucursalController(ICreateSucursalPresenter presenter, ICreateSucursalInputPort inputPort)
    {
        _presenter = presenter;
        _inputPort = inputPort;
    }
    
    public async ValueTask<int> Handle(CreateSucursalDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.SucursalId;
    }
}