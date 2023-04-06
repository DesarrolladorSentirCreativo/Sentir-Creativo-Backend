using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Prefijos;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Prefijos;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Prefijos;

public class SelectPrefijoPresenter : ISelectPrefijoPresenter
{
    public IReadOnlyList<SelectPrefijoViewModel> SelectPrefijoViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectPrefijoViewModel> modelView)
    {
        SelectPrefijoViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }
}