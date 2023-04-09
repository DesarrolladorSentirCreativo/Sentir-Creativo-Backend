using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Entities.ViewModels;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Audiencias;

public class PaginationAudienciaPresenter : IPaginationAudienciaPresenter
{
    public PaginationViewModel<AudienciaWithRelationsViewModels> PaginationAudiencia { get; private set; }
    
    public ValueTask Handle(PaginationViewModel<AudienciaWithRelationsViewModels> modelView)
    {
        PaginationAudiencia = modelView;

        return ValueTask.CompletedTask;
    }
    
}