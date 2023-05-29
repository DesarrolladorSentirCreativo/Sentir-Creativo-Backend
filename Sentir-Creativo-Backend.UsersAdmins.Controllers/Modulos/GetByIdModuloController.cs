using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Modulos;

public class GetByIdModuloController : IGetByIdModuloController
{
    private readonly IGetByIdModuloInputPort _inputPort;
    private readonly IGetByIdModuloPresenter _presenter;

    public GetByIdModuloController(
        IGetByIdModuloInputPort inputPort, IGetByIdModuloPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdModuloViewModel> Handle(int moduloId)
    {
        await _inputPort.Handle(moduloId);
        return _presenter.ModelView;
    }
}