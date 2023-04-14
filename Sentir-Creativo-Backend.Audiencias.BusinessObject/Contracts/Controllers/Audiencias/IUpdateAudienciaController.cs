using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;

public interface IUpdateAudienciaController
{
    ValueTask<int> Handle(UpdateAudienciaDto dto);
}