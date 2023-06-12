using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AFP;

public class UpdateAfpController : IUpdateAfpController
{
    private readonly IUpdateAfpInputPort _inputPort;
    private readonly IUpdateAfpPresenter  _presenter;
    
    public UpdateAfpController(IUpdateAfpInputPort inputPort, IUpdateAfpPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(UpdateAfpDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.AfpId;
    }
}