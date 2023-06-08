using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Roles;

public class GetAllRolPresenter : IGetAllRolPresenter
{
    public IReadOnlyList<GetAllRolViewModel> ModelViews { get; private set; }
    public ValueTask Handle(IReadOnlyList<GetAllRolViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}