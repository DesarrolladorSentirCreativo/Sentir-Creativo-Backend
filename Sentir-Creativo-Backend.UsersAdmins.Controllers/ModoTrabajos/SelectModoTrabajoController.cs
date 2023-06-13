using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ModoTrabajos;

public class SelectModoTrabajoController : ISelectModoTrabajoController
{
    private readonly ISelectModoTrabajoInputPort _inputPort;
    private readonly ISelectModoTrabajoPresenter  _presenter;
    
    public SelectModoTrabajoController(
        ISelectModoTrabajoInputPort inputPort,
        ISelectModoTrabajoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
   
    public async ValueTask<IReadOnlyList<SelectModoTrabajoViewModel>> Handle()
    {
        await _inputPort.Handle();

        return _presenter.ModelViews;
    }
}