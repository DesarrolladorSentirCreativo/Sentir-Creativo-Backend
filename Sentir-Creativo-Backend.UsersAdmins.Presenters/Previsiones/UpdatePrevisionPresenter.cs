using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Previsiones;

public class UpdatePrevisionPresenter : IUpdatePrevisionPresenter
{
    public ValueTask Handle(int previsionId)
    {
        PrevisionId = previsionId;
        
        return ValueTask.CompletedTask;
    }

    public int PrevisionId { get; private set; }
}