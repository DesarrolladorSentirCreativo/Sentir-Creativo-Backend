using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ModoTrabajos;

public class CreateModoTrabajoController : ICreateModoTrabajoController
{
    private readonly ICreateModoTrabajoInputPort _inputPort;
    private readonly ICreateModoTrabajoPresenter  _presenter;
    
    public CreateModoTrabajoController(
        ICreateModoTrabajoInputPort inputPort,
        ICreateModoTrabajoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateModoTrabajoDto dto)
    {
        await _inputPort.Handle(dto);
        
        return _presenter.ModoTrabajoId;
    }
}