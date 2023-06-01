using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Privilegios;

public class CreatePrivilegioController : ICreatePrivilegioController
{
    private readonly ICreatePrivilegioInputPort _inputPort;
    private readonly ICreatePrivilegioPresenter  _presenter;
    
    public CreatePrivilegioController(
        ICreatePrivilegioInputPort inputPort,
        ICreatePrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<string> Handle(CreatePrivilegioDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.PrivilegioId;
    }
}