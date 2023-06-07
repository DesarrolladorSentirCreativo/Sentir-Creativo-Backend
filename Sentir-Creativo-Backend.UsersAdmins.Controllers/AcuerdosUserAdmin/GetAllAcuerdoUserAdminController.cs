using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AcuerdosUserAdmin;

public class GetAllAcuerdoUserAdminController : IGetAllAcuerdoUserAdminController
{
    private readonly IGetAllAcuerdoUserAdminInputPort _inputPort;
    private readonly IGeAllAcuerdoUserAdminPresenter _presenter;
    
    public GetAllAcuerdoUserAdminController(
        IGetAllAcuerdoUserAdminInputPort inputPort, 
        IGeAllAcuerdoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<GetAllAcuerdoUserAdminViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}