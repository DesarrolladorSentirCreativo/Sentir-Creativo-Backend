using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ColeccionesUserAdmin;

public class GetAllColeccionUserAdminController : IGetAllColeccionUserAdminController
{
    private readonly IGetAllColeccionUserAdminInputPort _inputPort;
    private readonly IGetAllColeccionUserAdminPresenter _presenter;
    
    public GetAllColeccionUserAdminController(
        IGetAllColeccionUserAdminPresenter presenter,
        IGetAllColeccionUserAdminInputPort inputPort)
    {
        _presenter = presenter;
        _inputPort = inputPort;
    }
    
    public async ValueTask<IReadOnlyList<GetAllColeccionUserAdminViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}