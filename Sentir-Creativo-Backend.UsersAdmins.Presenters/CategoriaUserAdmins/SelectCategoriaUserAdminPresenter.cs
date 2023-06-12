using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaUserAdmins;

public class SelectCategoriaUserAdminPresenter : ISelectCategoriaUserAdminPresenter
{
    public IReadOnlyList<SelectCategoriaUserAdminViewModel> ViewModels { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectCategoriaUserAdminViewModel> viewModels)
    {
        ViewModels = viewModels;
        
        return ValueTask.CompletedTask;
    }
}