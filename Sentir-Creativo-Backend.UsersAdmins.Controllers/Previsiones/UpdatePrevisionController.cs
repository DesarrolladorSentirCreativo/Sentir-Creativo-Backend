using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Previsiones;

public class UpdatePrevisionController : IUpdatePrevisionController
{
    private readonly IUpdatePrevisionInputPort _inputPort;
    private readonly IUpdatePrevisionPresenter  _presenter;
    
    public UpdatePrevisionController(
        IUpdatePrevisionInputPort inputPort,
        IUpdatePrevisionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(UpdatePrevisionDto dto)
    {
        await _inputPort.Handle(dto);
        
        return _presenter.PrevisionId;
    }
}