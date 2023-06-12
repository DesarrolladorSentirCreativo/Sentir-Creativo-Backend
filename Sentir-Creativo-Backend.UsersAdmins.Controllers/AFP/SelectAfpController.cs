using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AFP;

public class SelectAfpController : ISelectAfpController
{
    private readonly ISelectAfpInputPort _inputPort;
    private readonly ISelectAfpPresenter  _presenter;
    
    public SelectAfpController(ISelectAfpInputPort inputPort, ISelectAfpPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectAfpViewModel>> Handle()
    {
            await _inputPort.Handle();
            return _presenter.ViewModels;
    }
}