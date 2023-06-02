using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAllWithColecciones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Modulos;

public class GetAllWithColeccionesModuloController : IGetAllWithColeccionesModuloController
{
    private readonly IGetAllWithColeccionesModuloInputPort _inputPort;
    private readonly IGetAllWithColeccionesModuloPresenter _presenter;

    public GetAllWithColeccionesModuloController(IGetAllWithColeccionesModuloPresenter presenter,
        IGetAllWithColeccionesModuloInputPort inputPort)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    
    public async ValueTask<IReadOnlyList<GetAllWithColeccionesModuloViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}