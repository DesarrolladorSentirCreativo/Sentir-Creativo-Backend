using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Privilegios;

public class SelectPrivilegioController : ISelectPrivilegioController
{
    private readonly ISelectPrivilegioInputPort _inputPort;
    private readonly ISelectPrivilegioPresenter  _presenter;

    public SelectPrivilegioController(
        ISelectPrivilegioInputPort inputPort, 
        ISelectPrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectPrivilegioViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}