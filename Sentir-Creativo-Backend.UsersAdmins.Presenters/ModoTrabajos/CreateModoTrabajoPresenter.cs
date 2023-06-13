using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.ModoTrabajos;

public class CreateModoTrabajoPresenter : ICreateModoTrabajoPresenter
{
    public int ModoTrabajoId { get; private set; }
    
    public ValueTask Handle(int modoTrabajoId)
    {
        ModoTrabajoId = modoTrabajoId;
        
        return ValueTask.CompletedTask;
    }

 
}