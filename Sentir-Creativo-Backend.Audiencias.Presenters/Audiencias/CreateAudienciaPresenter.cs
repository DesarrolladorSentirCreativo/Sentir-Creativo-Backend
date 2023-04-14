using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Audiencias;

public class CreateAudienciaPresenter : ICreateAudienciaPresenter
{
    public int Id { get; private set; }
    
    public ValueTask Handle(int audienciaId)
    {
        Id = audienciaId;
        
        return ValueTask.CompletedTask;
    }
}