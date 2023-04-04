using AutoMapper;
using MediatR;
using Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.ViewModel;
using Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Specifications;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Application.Features.ViewModels;

namespace Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.Queries.Paginator;

public class PaginationAudienciaQueryHandler : IRequestHandler<PaginationAudienciaQuery, PaginationViewModel<AudienciaViewModel>>
{
    private readonly IAudienciaReadRepository _audienciaReadRepository;
    private readonly IMapper _mapper;

    public PaginationAudienciaQueryHandler(IAudienciaReadRepository audienciaReadRepository, IMapper mapper)
    {
        this._audienciaReadRepository = audienciaReadRepository;
        this._mapper = mapper;
    }
    
    
    public async Task<PaginationViewModel<AudienciaViewModel>> Handle(PaginationAudienciaQuery request, CancellationToken cancellationToken)
    {
        var audienciaSpecificationParams = new AudienciaSpecificationParams
        {
            PageIndex = request.PageIndex,
            PageSize = request.PageSize,
            Search = request.Search,
            Sort = request.Sort
        };

        var spec = new AudienciaSpecification(audienciaSpecificationParams);
        var audiencias = await this._audienciaReadRepository.GetAllWithSpec(spec);

        var spectCount = new AudienciaForCountingSpecification(audienciaSpecificationParams);
        var totalAudiencias = await this._audienciaReadRepository.CountAsync(spectCount);
        
        var rounded = Math.Ceiling(Convert.ToDecimal(totalAudiencias) / Convert.ToDecimal(request.PageSize));
        var totalPages = Convert.ToInt32(rounded);

        var data = this._mapper.Map<IReadOnlyList<Audiencia>, IReadOnlyList<AudienciaViewModel>>(audiencias);

        var pagination = new PaginationViewModel<AudienciaViewModel>
        {
            Count = totalAudiencias,
            Data = data,
            PageCount = totalPages,
            PageIndex = request.PageIndex,
            PageSize = request.PageSize,
        };
        
        return pagination;
    }
}