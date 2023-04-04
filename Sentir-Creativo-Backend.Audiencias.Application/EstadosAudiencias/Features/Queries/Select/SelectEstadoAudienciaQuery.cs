using MediatR;
using Sentir_Creativo_Backend.Audiencias.Application.EstadosAudiencias.Features.ViewModels;

namespace Sentir_Creativo_Backend.Audiencias.Application.EstadosAudiencias.Features.Queries.Select;

public class SelectEstadoAudienciaQuery : IRequest<IReadOnlyList<SelectEstadoAudienciaViewModel>>
{
    
}