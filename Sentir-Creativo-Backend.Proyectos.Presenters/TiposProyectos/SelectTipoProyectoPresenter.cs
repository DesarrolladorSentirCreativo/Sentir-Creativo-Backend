using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Presenters.TipoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.TiposProyectos;

namespace Sentir_Creativo_Backend.Proyectos.Presenters.TiposProyectos;

public class SelectTipoProyectoPresenter : ISelectTipoProyectoPresenter
{
    public IReadOnlyList<SelectTipoProyectoViewModel> SelectTipoProyectoViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectTipoProyectoViewModel> modelView)
    {
        SelectTipoProyectoViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }
    
}