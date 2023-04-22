using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Delete;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;

public interface IDeleteAudienciaPresenter : IDeleteAudienciaOutputPort
{
    int AudienciaId { get;  }
}