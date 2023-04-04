using AutoMapper;
using MediatR;
using Sentir_Creativo_Backend.Audiencias.Application.EstadosAudiencias.Features.ViewModels;
using Sentir_Creativo_Backend.Audiencias.Application.EstadosAudiencias.Specifications;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.EstadoAudiencias;

namespace Sentir_Creativo_Backend.Audiencias.Application.EstadosAudiencias.Features.Queries.Select;

public class SelectEstadoAudienciaQueryHandler : IRequestHandler<SelectEstadoAudienciaQuery, IReadOnlyList<SelectEstadoAudienciaViewModel>>
{
    private readonly IEstadoAudienciaReadRepository _estadoAudienciaReadRepository;
    private readonly IMapper _mapper;
    
    public SelectEstadoAudienciaQueryHandler(IEstadoAudienciaReadRepository estadoAudienciaReadRepository, IMapper mapper)
    {
        _estadoAudienciaReadRepository = estadoAudienciaReadRepository;
        _mapper = mapper;
    }
    
    
    public async Task<IReadOnlyList<SelectEstadoAudienciaViewModel>> Handle(SelectEstadoAudienciaQuery request, CancellationToken cancellationToken)
    {
        var spec = new EstadoAudicienciaActivosSpecification();

        var estadoAudiencias = await this._estadoAudienciaReadRepository.GetAllWithSpec(spec);
        
        return this._mapper.Map<IReadOnlyList<EstadoAudiencia>, IReadOnlyList<SelectEstadoAudienciaViewModel>>(estadoAudiencias);
    }
}