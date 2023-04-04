using MediatR;
using Sentir_Creativo_Backend.Audiencias.Application.Prefijos.Features.ViewModel;

namespace Sentir_Creativo_Backend.Audiencias.Application.Prefijos.Features.Queries.Select;

public class SelectPrefijoQuery : IRequest<IReadOnlyList<SelectPrefijoViewModel>>
{
    
}