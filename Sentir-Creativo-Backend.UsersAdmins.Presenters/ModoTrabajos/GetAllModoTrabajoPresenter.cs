using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.ModoTrabajos;

public class GetAllModoTrabajoPresenter : IGetAllModoTrabajoPresenter
{
    public IReadOnlyList<GetAllModoTrabajoViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<GetAllModoTrabajoViewModel> viewModels)
    {
        ModelViews = viewModels;
        
        return ValueTask.CompletedTask;
    }
    
}