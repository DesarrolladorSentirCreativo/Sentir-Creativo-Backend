using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Previsiones;

public class GetByIdPrevisionController : IGetByIdPrevisionController
{
    private readonly IGetByIdPrevisionInputPort _inputPort;
    private readonly IGetByIdPrevisionPresenter  _presenter;
    
    public GetByIdPrevisionController(
        IGetByIdPrevisionInputPort inputPort,
        IGetByIdPrevisionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdPrevisionViewModel> Handle(int previsionId)
    {
        await _inputPort.Handle(previsionId);

        return _presenter.ViewModel;
    }
}