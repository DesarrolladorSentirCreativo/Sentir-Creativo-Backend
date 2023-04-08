using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.EstadoAudiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.EstadoAudiencias;

public interface ISelectEstadoAudienciaController
{
    ValueTask<IReadOnlyList<SelectEstadoAudienciaViewModel>> Handle();
}