using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaUserAdmins;

public class GetAllCategoriaUserAdminPresenter : IGetAllCategoriaUserAdminPresenter
{
    public IReadOnlyList<GetAllCategoriaUserAdminViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<GetAllCategoriaUserAdminViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}