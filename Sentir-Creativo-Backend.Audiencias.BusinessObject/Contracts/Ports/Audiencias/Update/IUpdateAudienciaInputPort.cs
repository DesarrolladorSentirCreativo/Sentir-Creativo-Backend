using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Update;

public interface IUpdateAudienciaInputPort
{
    ValueTask Handle(UpdateAudienciaDto dto);
}