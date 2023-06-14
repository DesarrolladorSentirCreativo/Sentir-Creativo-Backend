using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.EstadoUserAdmins;

public class UpdateEstadoUserAdminController : IUpdateEstadoUserAdminController
{
    private readonly IUpdateEstadoUserAdminInputPort _inputPort;
    private readonly IUpdateEstadoUserAdminPresenter  _presenter;
    
    public UpdateEstadoUserAdminController(
        IUpdateEstadoUserAdminInputPort inputPort, IUpdateEstadoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(UpdateEstadoUserAdminDto dto)
    {
        await _inputPort.Handle(dto);
        
        return _presenter.EstadoId;
    }
}