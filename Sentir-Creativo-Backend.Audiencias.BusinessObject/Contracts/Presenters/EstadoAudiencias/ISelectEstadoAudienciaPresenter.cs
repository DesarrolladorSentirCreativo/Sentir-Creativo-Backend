using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.EstadoAudiencias.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.EstadoAudiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.EstadoAudiencias;

public interface ISelectEstadoAudienciaPresenter : ISelectEstadoAudienciaOutputPort
{
    IReadOnlyList<SelectEstadoAudienciaViewModel> SelectEstadoAudienciaViewModel { get; }
}