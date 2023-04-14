using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Audiencias;

public class UpdateAudienciaPresenter : IUpdateAudienciaPresenter
{
    public int AudienciaId { get; private set; }
    
    public ValueTask Handle(int audienciaId)
    {
        AudienciaId = audienciaId;
        
        return ValueTask.CompletedTask;
    }
    
}