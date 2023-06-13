using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Previsiones;

public class GetAllPrevisionController : IGetAllPrevisionController
{
    private readonly IGetAllPrevisionInputPort _inputPort;
    private readonly IGetAllPrevisionPresenter  _presenter;
    
    public GetAllPrevisionController(
        IGetAllPrevisionInputPort inputPort,
        IGetAllPrevisionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<GetAllPrevisionViewModel>> Handle()
    {
        await _inputPort.Handle();

        return _presenter.ViewModels;
    }
}