using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters;

public interface ILoginUserAdminPresenter : ILoginUserAdminOutputPort
{
    public UserAdminTokenViewModel UserAdminTokenViewModel { get; }
}