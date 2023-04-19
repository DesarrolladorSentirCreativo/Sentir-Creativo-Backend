using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.AdminUser;

public class LoginUserAdminPresenter : ILoginUserAdminPresenter
{
    public UserAdminTokenViewModel UserAdminTokenViewModel { get; private set; }
    
    public ValueTask Handle(UserAdminTokenViewModel viewModel)
    {
         UserAdminTokenViewModel = viewModel;

         return ValueTask.CompletedTask;
    }
}