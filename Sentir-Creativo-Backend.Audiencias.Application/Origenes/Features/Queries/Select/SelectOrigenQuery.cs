using MediatR;
using Sentir_Creativo_Backend.Audiencias.Application.Origenes.Features.ViewModels;

namespace Sentir_Creativo_Backend.Audiencias.Application.Origenes.Features.Queries.Select;

public class SelectOrigenQuery : IRequest<IReadOnlyList<SelectOrigenViewModel>>
{
    
}