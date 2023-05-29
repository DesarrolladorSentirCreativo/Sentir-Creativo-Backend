using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Modulos;

public class GetAllModuloController : IGetAllModuloController
{
    private readonly IGetAllModuloInputPort _inputPort;
    private readonly IGetAllModuloPresenter _presenter;

    public GetAllModuloController(IGetAllModuloInputPort inputPort, IGetAllModuloPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<GetAllModuloViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}