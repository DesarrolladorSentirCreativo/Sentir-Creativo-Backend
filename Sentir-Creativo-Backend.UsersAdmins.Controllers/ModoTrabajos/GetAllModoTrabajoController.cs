using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ModoTrabajos;

public class GetAllModoTrabajoController : IGetAllModoTrabajoController
{
    private readonly IGetAllModoTrabajoInputPort _inputPort;
    private readonly IGetAllModoTrabajoPresenter  _presenter;
    
    public GetAllModoTrabajoController(
        IGetAllModoTrabajoInputPort inputPort,
        IGetAllModoTrabajoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<GetAllModoTrabajoViewModel>> Handle()
    {
        await _inputPort.Handle();

        return _presenter.ModelViews;
    }
}