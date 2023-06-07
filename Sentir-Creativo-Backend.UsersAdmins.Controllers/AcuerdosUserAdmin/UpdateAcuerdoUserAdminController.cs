using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AcuerdosUserAdmin;

public class UpdateAcuerdoUserAdminController : IUpdateAcuerdoUserAdminController
{
    private readonly IUpdateAcuerdoUserAdminInputPort _inputPort;
    private readonly IUpdateAcuerdoUserAdminPresenter _presenter;
    
    public UpdateAcuerdoUserAdminController(
        IUpdateAcuerdoUserAdminInputPort inputPort, 
        IUpdateAcuerdoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(UpdateAcuerdoUserAdminDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.AcuerdoId;
    }
}