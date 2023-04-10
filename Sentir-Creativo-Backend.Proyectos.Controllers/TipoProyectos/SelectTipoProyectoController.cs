using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Controllers.TipoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports.TipoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Presenters.TipoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.TiposProyectos;

namespace Sentir_Creativo_Backend.Proyectos.Controllers.TipoProyectos;

public class SelectTipoProyectoController : ISelectTipoProyectoController
{
    private readonly ISelectTipoProyectoInputPort _inputPort;
    private readonly ISelectTipoProyectoPresenter _presenter;
    
    public SelectTipoProyectoController(ISelectTipoProyectoInputPort inputPort, ISelectTipoProyectoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectTipoProyectoViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectTipoProyectoViewModel;
    }
}