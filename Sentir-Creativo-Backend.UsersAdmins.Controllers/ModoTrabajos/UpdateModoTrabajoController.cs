using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ModoTrabajos;

public class UpdateModoTrabajoController : IUpdateModoTrabajoController
{
    private readonly IUpdateModoTrabajoInputPort _inputPort;
    private readonly IUpdateModoTrabajoPresenter  _presenter;
    
    public UpdateModoTrabajoController(
        IUpdateModoTrabajoInputPort inputPort,
        IUpdateModoTrabajoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(UpdateModoTrabajoDto dto)
    {
        await _inputPort.Handle(dto);
        
        return _presenter.ModoTrabajoId;
    }
}