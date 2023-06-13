using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Previsiones;

public class SelectPrevisionController : ISelectPrevisionController
{
    private readonly ISelectPrevisionInputPort _inputPort;
    private readonly ISelectPrevisionPresenter  _presenter;
    
    public SelectPrevisionController(
        ISelectPrevisionInputPort inputPort,
        ISelectPrevisionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectPrevisionViewModel>> Handle()
    {
        await _inputPort.Handle();

        return _presenter.ViewModels;
    }
}