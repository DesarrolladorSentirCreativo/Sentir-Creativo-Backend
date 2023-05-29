using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Modulos;

public class CreateModuloController : ICreateModuloController
{
    private readonly ICreateModuloInputPort _inputPort;
    private readonly ICreateModuloPresenter _presenter;

    public CreateModuloController(
        ICreateModuloInputPort inputPort, 
        ICreateModuloPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateModuloDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.ModuloId;
    }
}