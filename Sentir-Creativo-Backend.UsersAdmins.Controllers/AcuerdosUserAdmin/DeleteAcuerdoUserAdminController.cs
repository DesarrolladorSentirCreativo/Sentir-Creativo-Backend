using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AcuerdosUserAdmin;

public class DeleteAcuerdoUserAdminController : IDeleteAcuerdoUserAdminController
{
    private readonly IDeleteAcuerdoUserAdminInputPort _inputPort;
    private readonly IDeleteAcuerdoUserAdminPresenter _presenter;

    public DeleteAcuerdoUserAdminController(
        IDeleteAcuerdoUserAdminInputPort inputPort,
        IDeleteAcuerdoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<int> Handle(int acuerdoId)
    {
        await _inputPort.Handle(acuerdoId);
        return _presenter.AcuerdoId;
    }
}