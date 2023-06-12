using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AFP;

public class CreateAfpController : ICreateAfpController
{
    private readonly ICreateAfpInputPort _inputPort;
    private readonly ICreateAfpPresenter  _presenter;
    
    public CreateAfpController(
        ICreateAfpInputPort inputPort,
        ICreateAfpPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateAfpDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.AfpId;
    }
}