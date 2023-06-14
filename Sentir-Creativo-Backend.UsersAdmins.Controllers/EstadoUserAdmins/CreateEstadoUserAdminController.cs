using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.EstadoUserAdmins;

public class CreateEstadoUserAdminController : ICreateEstadoUserAdminController
{
    private readonly ICreateEstadoUserAdminInputPort _inputPort;
    private readonly ICreateEstadoUserAdminPresenter  _presenter;
    
    public CreateEstadoUserAdminController(
        ICreateEstadoUserAdminInputPort inputPort,
        ICreateEstadoUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateEstadoUserAdminDto dto)
    {
        await _inputPort.Handle(dto);
        
        return _presenter.EstadoId;
    }
}