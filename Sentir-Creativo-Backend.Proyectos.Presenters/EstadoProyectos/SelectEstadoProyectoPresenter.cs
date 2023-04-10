using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Presenters.EstadoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.EstadoProyectos;

namespace Sentir_Creativo_Backend.Proyectos.Presenters.EstadoProyectos;

public class SelectEstadoProyectoPresenter : ISelectEstadoProyectoPresenter
{
    public IReadOnlyList<SelectEstadoProyectoViewModel> SelectEstadoProyectoViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectEstadoProyectoViewModel> modelView)
    {
        SelectEstadoProyectoViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }

    
}