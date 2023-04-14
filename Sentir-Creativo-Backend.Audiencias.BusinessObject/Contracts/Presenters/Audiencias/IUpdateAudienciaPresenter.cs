using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Update;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;

public interface IUpdateAudienciaPresenter : IUpdateAudienciaOutputPort
{
    int AudienciaId { get; }
}