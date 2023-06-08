using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Roles;

public class GetByIdRolPresenter : IGetByIdRolPresenter
{
    public GetByIdRolViewModel ModelView { get; private set; }
    
    public ValueTask Handle(GetByIdRolViewModel modelView)
    {
        ModelView = modelView;
        
        return ValueTask.CompletedTask;
    }
}