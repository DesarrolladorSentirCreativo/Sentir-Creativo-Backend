using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetById;

public interface IGetByIdAudienciaOutputPort
{
    ValueTask Handle(GetByIdAudienciaViewModel modelView);
}