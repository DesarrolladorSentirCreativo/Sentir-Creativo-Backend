using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Antiguedades;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Antiguedades;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Antiguedades;

public class SelectAntiguedadPresenter : ISelectAntiguedadPresenter
{
    public IReadOnlyList<SelectAntiguedadViewModel> SelectAntiguedadViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectAntiguedadViewModel> modelView)
    {
        SelectAntiguedadViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }

   
}