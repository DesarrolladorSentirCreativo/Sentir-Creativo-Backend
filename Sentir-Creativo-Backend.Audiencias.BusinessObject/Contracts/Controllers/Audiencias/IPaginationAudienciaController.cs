using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Entities.ViewModels;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;

public interface IPaginationAudienciaController
{
    ValueTask<PaginationViewModel<AudienciaWithRelationsViewModels>> Handle(AudienciaPaginationDto dto);
}