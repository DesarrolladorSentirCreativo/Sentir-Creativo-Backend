using Microsoft.Extensions.Logging;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetAll;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.GetAll;

public class GetAllAudienciaInteractor : IGetAllAudienciaInputPort
{
    private readonly IReadRepository<Entities.POCOEntities.Audiencia,int> _readRepository;
    private readonly IGetAllAudienciaOutputPort _outputPort;
    private readonly ILogger<GetAllAudienciaInteractor> _logger;

    public GetAllAudienciaInteractor(IReadRepository<Entities.POCOEntities.Audiencia,int> readRepository, 
        IGetAllAudienciaOutputPort outputPort,
        ILogger<GetAllAudienciaInteractor> logger)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
        _logger = logger;
    }
    
    public async ValueTask Handle()
    {
        var spec = new AudienciaActivosSpecification();

        var audiencias = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllAudienciaViewModel> data = audiencias
            .Select(p => 
                new GetAllAudienciaViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre!,
                    Apellido = p.Apellido,
                    Profesion = p.Profesion,
                    Email = p.Email!,
                    Celular = p.Celular,
                    OrganizacionId = p.OrganizacionId,
                    Departamento = p.Departamento,
                    Cargo = p.Cargo,
                    AntiguedadId = p.AntiguedadId,
                    CercaniaId = p.CercaniaId,
                    MotivacionId = p.MotivacionId,
                    EstadoId = p.EstadoId,
                    PrefijoId = p.PrefijoId,
                    OrigenId = p.OrigenId,
                    Email2 = p.Email2,
                    Destacado = p.Destacado,
                    DocumentoIdentidad = p.DocumentoIdentidad,
                    Activo = p.Activo,
                    PublishedAt = p.PublishedAt
                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}