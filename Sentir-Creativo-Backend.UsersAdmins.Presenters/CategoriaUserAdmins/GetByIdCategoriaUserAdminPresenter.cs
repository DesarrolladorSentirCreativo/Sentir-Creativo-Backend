using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaUserAdmins;

public class GetByIdCategoriaUserAdminPresenter : IGetByIdCategoriaUserAdminPresenter
{
    public GetByIdCategoriaUserAdminViewModel ViewModel { get; private set; }
    
    public ValueTask Handle(GetByIdCategoriaUserAdminViewModel viewModel)
    {
        ViewModel = viewModel;
        
        return ValueTask.CompletedTask;
    }
    
}