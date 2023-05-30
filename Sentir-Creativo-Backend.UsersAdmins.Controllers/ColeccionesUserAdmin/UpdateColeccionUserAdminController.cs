using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ColeccionesUserAdmin;

public class UpdateColeccionUserAdminController : IUpdateColeccionUserAdminController
{
    private readonly IUpdateColeccionUserAdminInputPort _inputPort;
    private readonly IUpdateColeccionUserAdminPresenter _presenter;
    
    public UpdateColeccionUserAdminController(
        IUpdateColeccionUserAdminPresenter presenter,
        IUpdateColeccionUserAdminInputPort inputPort)
    {
        _presenter = presenter;
        _inputPort = inputPort;
    }


    public async ValueTask<int> Handle(UpdateColeccionUserAdminDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.ColeccionUserAdminId;
    }
}