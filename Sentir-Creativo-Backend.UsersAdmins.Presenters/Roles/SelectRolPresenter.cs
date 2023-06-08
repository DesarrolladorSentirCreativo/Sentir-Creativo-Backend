using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Roles;

public class SelectRolPresenter : ISelectRolPresenter
{
    public IReadOnlyList<SelectRolViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectRolViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
}