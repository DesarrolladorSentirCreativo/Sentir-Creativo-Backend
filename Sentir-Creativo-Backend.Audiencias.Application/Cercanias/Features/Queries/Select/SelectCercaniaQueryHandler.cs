using AutoMapper;
using MediatR;
using Sentir_Creativo_Backend.Audiencias.Application.Cercanias.Features.ViewModels;
using Sentir_Creativo_Backend.Audiencias.Application.Cercanias.Specifications;
using Sentir_Creativo_Backend.Audiencias.Application.Origenes.Features.ViewModels;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Cercanias;

namespace Sentir_Creativo_Backend.Audiencias.Application.Cercanias.Features.Queries.Select;

public class SelectCercaniaQueryHandler : IRequestHandler<SelectCercaniaQuery, IReadOnlyList<SelectCercaniaViewModel>>
{
    private readonly ICercaniaReadRepository _cercaniaReadRepository;
    private readonly IMapper _mapper;

    public SelectCercaniaQueryHandler(ICercaniaReadRepository cercaniaReadRepository, IMapper mapper)
    {
        _cercaniaReadRepository = cercaniaReadRepository;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<SelectCercaniaViewModel>> Handle(SelectCercaniaQuery request, CancellationToken cancellationToken)
    {
        var spec = new CercaniaActivosSpecification();

        var cercanias = await _cercaniaReadRepository.GetAllWithSpec(spec);
        
        return _mapper.Map<IReadOnlyList<Cercania>, IReadOnlyList<SelectCercaniaViewModel>>(cercanias);
    }
}