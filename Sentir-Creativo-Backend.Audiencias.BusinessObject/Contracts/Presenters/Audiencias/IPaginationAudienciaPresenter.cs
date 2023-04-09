using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Pagination;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Entities.ViewModels;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;

public interface IPaginationAudienciaPresenter : IPaginationAudienciaOuputPort
{
    PaginationViewModel<AudienciaWithRelationsViewModels> PaginationAudiencia { get; }
}