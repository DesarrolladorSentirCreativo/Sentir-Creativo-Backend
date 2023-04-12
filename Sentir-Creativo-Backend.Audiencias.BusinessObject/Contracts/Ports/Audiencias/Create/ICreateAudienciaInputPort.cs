using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Create;

public interface ICreateAudienciaInputPort
{
    ValueTask Handle(CreateAudienciaDto dto);
}