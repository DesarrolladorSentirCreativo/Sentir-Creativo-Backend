using MediatR;
using Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.ViewModel;
using Sentir_Creativo_Backend.SharedKernel.Application.Features.Queries;
using Sentir_Creativo_Backend.SharedKernel.Application.Features.ViewModels;

namespace Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.Queries.Paginator;

public class PaginationAudienciaQuery : PaginationBaseQuery , IRequest<PaginationViewModel<AudienciaViewModel>>
{
}