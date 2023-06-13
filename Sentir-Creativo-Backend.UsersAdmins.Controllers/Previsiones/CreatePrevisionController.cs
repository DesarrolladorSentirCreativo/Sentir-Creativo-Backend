using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Previsiones;

public class CreatePrevisionController : ICreatePrevisionController
{
    private readonly ICreatePrevisionInputPort _inputPort;
    private readonly ICreatePrevisionPresenter  _presenter;
    
    public CreatePrevisionController(
        ICreatePrevisionInputPort inputPort,
        ICreatePrevisionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreatePrevisionDto dto)
    {
        await _inputPort.Handle(dto);
        
        return _presenter.PrevisionId;
    }
}