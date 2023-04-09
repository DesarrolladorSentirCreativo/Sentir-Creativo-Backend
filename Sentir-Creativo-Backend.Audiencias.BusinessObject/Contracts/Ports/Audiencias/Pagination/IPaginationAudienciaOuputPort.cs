using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Entities.ViewModels;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Pagination;

public interface IPaginationAudienciaOuputPort
{
    ValueTask Handle(PaginationViewModel<AudienciaWithRelationsViewModels> modelView);
}