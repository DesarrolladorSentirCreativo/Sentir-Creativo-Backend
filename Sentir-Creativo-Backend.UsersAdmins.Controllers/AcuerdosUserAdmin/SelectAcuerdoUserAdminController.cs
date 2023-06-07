using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AcuerdosUserAdmin;

public class SelectAcuerdoUserAdminController : ISelectAcuerdoUserAdminController
{
    private readonly ISelectAcuerdoUserAdminInputPort _inputPort;
    private readonly ISelectAcuerdoUserAdminPresenter _presenter;

    public SelectAcuerdoUserAdminController(
        ISelectAcuerdoUserAdminInputPort inputPort,
        ISelectAcuerdoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<IReadOnlyList<SelectAcuerdoUserAdminViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}