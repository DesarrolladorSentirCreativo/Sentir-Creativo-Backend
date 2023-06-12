using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.AFP;

public class CreateAfpPresenter : ICreateAfpPresenter
{
    public int AfpId { get; private set; }
    public ValueTask Handle(int afpId)
    {
        AfpId = afpId;
        
        return ValueTask.CompletedTask;
    }
    
}