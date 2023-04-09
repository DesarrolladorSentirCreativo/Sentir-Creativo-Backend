using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Pagination;

public interface IPaginationAudienciaInputPort
{
    ValueTask Handle(AudienciaPaginationDto dto);
}