using AutoMapper;
using MediatR;
using Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Specifications;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.Commands.Creator;

public class CreateAudienciaCommandHandler : IRequestHandler<CreateAudienciaCommand,int>
{
    private readonly IAudienciaWriteRepository _audienciaWriteRepository;
    private readonly IAudienciaReadRepository _audienciaReadRepository;
    private readonly IMapper _mapper;

    public CreateAudienciaCommandHandler(
        IAudienciaWriteRepository audienciaWriteRepository, 
        IAudienciaReadRepository audienciaReadRepository,
        IMapper mapper)
    {
        _audienciaWriteRepository = audienciaWriteRepository;
        _audienciaReadRepository = audienciaReadRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateAudienciaCommand request, CancellationToken cancellationToken)
    {
        // validacion de que el documento identidad y email no se encuentren registrados
        var specParams = new AudienciaExistsSpecificationParams
        {
            Email = request.Email,
            DocumentoIdentidad = request.DocumentoIdentidad
        };
        var spec = new AudienciaExistsSpecification(specParams);
        var result = await _audienciaReadRepository.GetAllWithSpec(spec);

        if (result.Count > 0)
        {
            throw new ApplicationException("La audiencia ya se encuentra registrada");
        }
        
        // se incie el proceso de registro de la audiencia
        var audiencia = _mapper.Map<Audiencia>(request);

        audiencia.PublishedAt = DateTime.Now;

        await _audienciaWriteRepository.AddAsync(audiencia);

        return audiencia.Id;
    }
}