using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Audiencias;

public class SearchAudienciasDifusionPresenter : ISearchAudienciasDifusionPresenter
{
    public SearchAudienciasDifusionViewModel SearchAudienciasDifusionViewModel { get; private set; }
    
    public ValueTask Handle(SearchAudienciasDifusionViewModel modelView)
    {
        SearchAudienciasDifusionViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }
}