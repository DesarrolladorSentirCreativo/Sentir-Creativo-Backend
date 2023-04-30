using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Rubros;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Rubros;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Rubros;

public class SelectRubroPresenter : ISelectRubroPresenter
{
    public IReadOnlyList<SelectRubroViewModel> SelectRubros { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectRubroViewModel> viewModels)
    {
        SelectRubros = viewModels;
        
        return ValueTask.CompletedTask;
    }
}