using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ColeccionesUserAdmin;

public class SelectColeccionUserAdminController : ISelectColeccionUserAdminController
{
    private readonly ISelectColeccionUserAdminInputPort _inputPort;
    private readonly ISelectColeccionUserAdminAdminPresenter  _presenter;

    public SelectColeccionUserAdminController(ISelectColeccionUserAdminInputPort inputPort,
        ISelectColeccionUserAdminAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectColeccionUserAdminViewModel>> Handle()
    {
        
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}