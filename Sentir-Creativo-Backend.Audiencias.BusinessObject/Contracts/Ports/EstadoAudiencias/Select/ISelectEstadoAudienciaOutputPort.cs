using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.EstadoAudiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.EstadoAudiencias.Select;

public interface ISelectEstadoAudienciaOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectEstadoAudienciaViewModel> modelView);
}