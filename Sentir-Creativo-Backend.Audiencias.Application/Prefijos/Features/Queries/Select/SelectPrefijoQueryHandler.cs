using AutoMapper;
using MediatR;
using Sentir_Creativo_Backend.Audiencias.Application.Prefijos.Features.ViewModel;
using Sentir_Creativo_Backend.Audiencias.Application.Prefijos.Specifications;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Prefijos;

namespace Sentir_Creativo_Backend.Audiencias.Application.Prefijos.Features.Queries.Select;

public class SelectPrefijoQueryHandler : IRequestHandler<SelectPrefijoQuery,IReadOnlyList<SelectPrefijoViewModel>>
{
    private readonly IPrefijoReadRepository _prefijoReadRepository;
    private readonly IMapper _mapper;

    public SelectPrefijoQueryHandler(IPrefijoReadRepository prefijoReadRepository, IMapper mapper)
    {
        this._prefijoReadRepository = prefijoReadRepository;
        this._mapper = mapper;
    }

    public async Task<IReadOnlyList<SelectPrefijoViewModel>> Handle(SelectPrefijoQuery request, CancellationToken cancellationToken)
    {
        var spec = new PrefijoActivosSpecification();

        var prefijos = await this._prefijoReadRepository.GetAllWithSpec(spec);
        
        return this._mapper.Map<IReadOnlyList<Prefijo>, IReadOnlyList<SelectPrefijoViewModel>>(prefijos);
    }
}