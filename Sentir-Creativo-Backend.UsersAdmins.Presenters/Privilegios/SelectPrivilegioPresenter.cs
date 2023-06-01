using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Privilegios;

public class SelectPrivilegioPresenter : ISelectPrivilegioPresenter
{
    public IReadOnlyList<SelectPrivilegioViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectPrivilegioViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}