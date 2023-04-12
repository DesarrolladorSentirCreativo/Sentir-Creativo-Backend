using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Create;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;

public interface ICreateAudienciaPresenter : ICreateAudienciaOutputPort
{
    int Id { get; }
}