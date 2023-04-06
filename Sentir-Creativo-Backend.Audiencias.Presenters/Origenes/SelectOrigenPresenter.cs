using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Origenes;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Origenes;

public class SelectOrigenPresenter : ISelectOrigenPresenter
{
    public IReadOnlyList<SelectOrigenViewModel> SelectOrigenViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectOrigenViewModel> modelView)
    {
        SelectOrigenViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }

    
}