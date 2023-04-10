using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Controllers.EstadoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports.EstadoProyectos.Select;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Presenters.EstadoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.EstadoProyectos;

namespace Sentir_Creativo_Backend.Proyectos.Controllers.EstadoProyectos;

public class SelectEstadoProyectoController : ISelectEstadoProyectoController
{
    private readonly ISelectEstadoProyectoInputPort _inputPort;
    private readonly ISelectEstadoProyectoPresenter _presenter;

    public SelectEstadoProyectoController(ISelectEstadoProyectoInputPort inputPort,
        ISelectEstadoProyectoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    
    public async ValueTask<IReadOnlyList<SelectEstadoProyectoViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectEstadoProyectoViewModel;
    }
}