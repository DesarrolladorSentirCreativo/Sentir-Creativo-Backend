using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.AFP;

public class UpdateAfpPresenter : IUpdateAfpPresenter
{
    public ValueTask Handle(int afpId)
    {
        AfpId = afpId;
        
        return ValueTask.CompletedTask;
    }

    public int AfpId { get; private set; }
}