using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AcuerdosUserAdmin;

public class GetByIdAcuerdoUserAdminController : IGetByIdAcuerdoUserAdminControiller
{
    private readonly IGetByIdAcuerdoUserAdminInputPort _inputPort;
    private readonly IGetByIdAcuerdoUserAdminPresenter _presenter;

    public GetByIdAcuerdoUserAdminController(
        IGetByIdAcuerdoUserAdminInputPort inputPort,
        IGetByIdAcuerdoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<GetByIdAcuerdoUserAdminViewModel> Handle(int acuerdoId)
    {
        await _inputPort.Handle(acuerdoId);
        return _presenter.ModelView;
    }
}