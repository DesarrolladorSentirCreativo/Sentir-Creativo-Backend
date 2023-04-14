using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;

public interface ICreateAudienciaController
{
    ValueTask<int> Handle(CreateAudienciaDto dto);
}