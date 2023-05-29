using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Modulos;

public class DeleteModuloController : IDeleteModuloController
{
    private readonly IDeleteModuloInputPort _inputPort;
    private readonly IDeleteModuloPresenter _presenter;

    public DeleteModuloController(
        IDeleteModuloInputPort inputPort, 
        IDeleteModuloPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int moduloId)
    {
        await _inputPort.Handle(moduloId);
        return _presenter.ModuloId;
    }
}