using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ColeccionesUserAdmin;

public class CreateColeccionUserAdminController : ICreateColeccionUserAdminController
{
    private readonly ICreateColeccionUserAdminInputPort _inputPort;
    private readonly ICreateColeccionUserAdminPresenter _presenter;
    
    public CreateColeccionUserAdminController(
        ICreateColeccionUserAdminPresenter presenter,
        ICreateColeccionUserAdminInputPort inputPort)
    {
        _presenter = presenter;
        _inputPort = inputPort;
    }
    
    public async ValueTask<int> Handle(CreateColeccionUserAdminDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.ColeccionUserAdminId;
    }
}