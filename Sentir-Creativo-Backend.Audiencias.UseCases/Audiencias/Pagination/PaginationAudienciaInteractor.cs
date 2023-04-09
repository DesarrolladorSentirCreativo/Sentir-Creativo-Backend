using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Pagination;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.ViewModels;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Pagination;

public class PaginationAudienciaInteractor : IPaginationAudienciaInputPort
{
    private readonly IReadRepository<Entities.POCOEntities.Audiencia,int> _readRepository;
    private readonly IPaginationAudienciaOuputPort _outputPort;
    
    public PaginationAudienciaInteractor(IReadRepository<Entities.POCOEntities.Audiencia,int> readRepository,
     IPaginationAudienciaOuputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle(AudienciaPaginationDto dto)
    {
        var specParams = new AudienciaPaginationSpecificationParams
        {
            PageIndex = dto.PageIndex,
            PageSize = dto.PageSize,
            Search = dto.Search,
            Sort = dto.Sort
        };
        
        var spec = new AudienciaPaginationSpecification(specParams);

        var audiencias = await _readRepository.GetAllWithSpec(spec);
        
        var spectCount = new AudienciaForCountingSpecification(specParams);
        var totalAudiencias = await _readRepository.CountAsync(spectCount);
        
        var rounded = Math.Ceiling(Convert.ToDecimal(totalAudiencias) / Convert.ToDecimal(dto.PageSize));
        var totalPages = Convert.ToInt32(rounded);
        
        IReadOnlyList<AudienciaWithRelationsViewModels> data = audiencias
            .Select(p => 
                new AudienciaWithRelationsViewModels ()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Profesion = p.Profesion,
                    Email = p.Email,
                    Celular = p.Celular,
                    Organizacion = p.Organizacion?.Nombre,
                    Departamento = p.Departamento,
                    Cargo = p.Cargo,
                    Antiguedad = p.Antiguedad?.Nombre,
                    Cercania = p.Cercania?.Nombre,
                    Motivacion = p.Motivacion?.Nombre,
                    Estado = p.EstadoAudiencia?.Nombre,
                    Prefijo = p.Prefijo?.Nombre,
                    Origen = p.Origen?.Nombre,
                    Email2 = p.Email2,
                    Destacado = p.Destacado,
                    DocumentoIdentidad = p.DocumentoIdentidad,
                    Activo = p.Activo
                })
            .ToList()
            .AsReadOnly();

        var pagination = new PaginationViewModel<AudienciaWithRelationsViewModels>()
        {
            Count = totalAudiencias,
            Data = data,
            PageCount = totalPages,
            PageIndex = dto.PageIndex,
            PageSize = dto.PageSize,
        };
        
        await _outputPort.Handle(pagination);
    }
}