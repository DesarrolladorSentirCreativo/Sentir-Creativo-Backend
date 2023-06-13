using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.ModoTrabajos;

public class SelectModoTrabajoPresenter : ISelectModoTrabajoPresenter
{
    public IReadOnlyList<SelectModoTrabajoViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectModoTrabajoViewModel> viewModels)
    {
        ModelViews = viewModels;
        
        return ValueTask.CompletedTask;
    }
    
}