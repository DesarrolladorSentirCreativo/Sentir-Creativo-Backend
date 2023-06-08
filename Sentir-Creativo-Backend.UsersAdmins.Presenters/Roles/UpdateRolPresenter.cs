using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Roles;

public class UpdateRolPresenter : IUpdateRolPresenter
{
    public int RolId { get; private set; }
    
    public ValueTask Handle(int rolId)
    {
        RolId = rolId;
        
        return ValueTask.CompletedTask;
    }
    
}