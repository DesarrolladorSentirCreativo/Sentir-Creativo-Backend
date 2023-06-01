using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Privilegios;

public class UpdatePrivilegioController : IUpdatePrivilegioController
{
    private readonly IUpdatePrivilegioInputPort _inputPort;
    private readonly IUpdatePrivilegioPresenter  _presenter;

    public UpdatePrivilegioController(
        IUpdatePrivilegioInputPort inputPort,
        IUpdatePrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<string> Handle(UpdatePrivilegioDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.PrivilegioId;
    }
}