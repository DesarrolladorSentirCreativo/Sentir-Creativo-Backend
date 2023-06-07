using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.AcuerdosUserAdmin;

public class CreateAcuerdoUserAdminController : ICreateAcuerdoUserAdminController
{
    private readonly ICreateAcuerdoUserAdminInputPort _inputPort;
    private readonly ICreateAcuerdoUserAdminPresenter _presenter;
    
    public CreateAcuerdoUserAdminController(
        ICreateAcuerdoUserAdminInputPort inputPort, 
        ICreateAcuerdoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateAcuerdoUserAdminDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.AcuerdoId;
    }
}