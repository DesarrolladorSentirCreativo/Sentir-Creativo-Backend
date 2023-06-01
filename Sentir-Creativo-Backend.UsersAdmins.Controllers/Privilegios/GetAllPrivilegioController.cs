using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Privilegios;

public class GetAllPrivilegioController : IGetAllPrivilegioController
{
    
    private readonly IGetAllPrivilegioInputPort _inputPort;
    private readonly IGetAllPrivilegioPresenter  _presenter;

    public GetAllPrivilegioController(
        IGetAllPrivilegioInputPort inputPort, 
        IGetAllPrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<GetAllPrivilegioViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}