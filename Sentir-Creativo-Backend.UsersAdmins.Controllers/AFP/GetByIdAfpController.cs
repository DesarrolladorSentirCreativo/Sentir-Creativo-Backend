using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AFP;

public class GetByIdAfpController : IGetByIdAfpController
{
    private readonly IGetByIdAfpInputPort _inputPort;
    private readonly IGetByIdAfpPresenter  _presenter;
    
    public GetByIdAfpController(IGetByIdAfpInputPort inputPort, IGetByIdAfpPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdAfpViewModel> Handle(int afpId)
    {
        await _inputPort.Handle(afpId);
        return _presenter.ViewModel;
    }
}