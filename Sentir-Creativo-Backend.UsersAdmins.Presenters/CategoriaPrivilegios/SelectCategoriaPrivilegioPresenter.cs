using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaPrivilegios;

public class SelectCategoriaPrivilegioPresenter : ISelectCategoriaPrivilegioPresenter
{
    public IReadOnlyList<SelectCategoriaPrivilegioViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectCategoriaPrivilegioViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}