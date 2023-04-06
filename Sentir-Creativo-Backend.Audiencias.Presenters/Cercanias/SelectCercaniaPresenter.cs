using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Cercanias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Cercanias;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Cercanias;

public class SelectCercaniaPresenter : ISelectCercaniaPresenter
{
    public IReadOnlyList<SelectCercaniaViewModel> SelectCercaniaViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectCercaniaViewModel> modelView)
    {
        SelectCercaniaViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }
}