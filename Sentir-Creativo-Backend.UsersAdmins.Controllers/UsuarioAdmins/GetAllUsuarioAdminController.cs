using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.UsuarioAdmins;

public class GetAllUsuarioAdminController : IGetAllUsuarioAdminController
{
    private readonly IGetAllUsuarioAdminInputPort _inputPort;
    private readonly IGetAllUsuarioAdminPresenter _presenter;
    
    public GetAllUsuarioAdminController(
        IGetAllUsuarioAdminInputPort inputPort,
        IGetAllUsuarioAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<GetAllUsuarioAdminViewModel>> Handle()
    {
        await _inputPort.Handle();

        return _presenter.ViewModels;
    }
}