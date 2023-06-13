using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Previsiones;

public class CreatePrevisionPresenter : ICreatePrevisionPresenter
{
    public int PrevisionId { get; private set; }
    
    public ValueTask Handle(int previsionId)
    {
        PrevisionId = previsionId;
        
        return ValueTask.CompletedTask;
    }
    
}