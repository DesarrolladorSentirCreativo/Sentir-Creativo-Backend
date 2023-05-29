using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Modulos;

public class UpdateModuloController : IUpdateModuloController
{
    private readonly IUpdateModuloInputPort _inputPort;
    private readonly IUpdateModuloPresenter _presenter;

    public UpdateModuloController(
        IUpdateModuloInputPort inputPort, 
        IUpdateModuloPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter; 
    }
    
    public async ValueTask<int> Handle(UpdateModuloDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.ModuloId;
    }
}