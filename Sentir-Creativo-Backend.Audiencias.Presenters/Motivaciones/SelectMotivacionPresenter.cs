using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Motivaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Motivaciones;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Motivaciones;

public class SelectMotivacionPresenter: ISelectMotivacionPresenter
{
    public IReadOnlyList<SelectMotivacionViewModel> SelectMotivacionViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectMotivacionViewModel> modelView)
    {
        SelectMotivacionViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }
}