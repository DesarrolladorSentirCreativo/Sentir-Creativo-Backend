using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AFP;

public class GetAllAfpController : IGetAllAfpController
{
    private readonly IGetAllAfpInputPort _inputPort;
    private readonly IGetAllAfpPresenter  _presenter;
    
    public GetAllAfpController(IGetAllAfpInputPort inputPort, IGetAllAfpPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<GetAllAfpViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ViewModels;
    }
}