using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Audiencias;

public class GetByIdAudienciaPresenter : IGetByIdAudienciaPresenter
{
    public GetByIdAudienciaViewModel GetByIdAudenciaViewModel { get; private set; }
    
    public ValueTask Handle(GetByIdAudienciaViewModel modelView)
    {
        GetByIdAudenciaViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }
}