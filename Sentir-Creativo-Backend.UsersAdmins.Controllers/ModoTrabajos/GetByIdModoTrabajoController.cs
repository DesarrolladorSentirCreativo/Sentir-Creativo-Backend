using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ModoTrabajos;

public class GetByIdModoTrabajoController : IGetByIdModoTrabajoController
{
    private readonly IGetByIdModoTrabajoInputPort _inputPort;
    private readonly IGetByIdModoTrabajoPresenter  _presenter;
    
    public GetByIdModoTrabajoController(
        IGetByIdModoTrabajoInputPort inputPort,
        IGetByIdModoTrabajoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdModoTrabajoViewModel> Handle(int modoTrabajoId)
    {
        await _inputPort.Handle(modoTrabajoId);

        return _presenter.ModelView;
    }
}