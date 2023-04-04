using AutoMapper;
using MediatR;
using Sentir_Creativo_Backend.Audiencias.Application.Origenes.Features.ViewModels;
using Sentir_Creativo_Backend.Audiencias.Application.Origenes.Specifications;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Origenes;

namespace Sentir_Creativo_Backend.Audiencias.Application.Origenes.Features.Queries.Select;

public class SelectOrigenQueryHandler : IRequestHandler<SelectOrigenQuery, IReadOnlyList<SelectOrigenViewModel>>
{
    private readonly IOrigenReadRepository _origenReadRepository;
    private readonly IMapper _mapper;

    public SelectOrigenQueryHandler(IOrigenReadRepository origenReadRepository, IMapper mapper)
    {
        _origenReadRepository = origenReadRepository;
        _mapper = mapper;
    }
    
    public async Task<IReadOnlyList<SelectOrigenViewModel>> Handle(SelectOrigenQuery request, CancellationToken cancellationToken)
    {
        var spec = new OrigenActivosSpecification();

        var origenes = await _origenReadRepository.GetAllWithSpec(spec);
        
        return this._mapper.Map<IReadOnlyList<Origen>, IReadOnlyList<SelectOrigenViewModel>>(origenes);
    }
}