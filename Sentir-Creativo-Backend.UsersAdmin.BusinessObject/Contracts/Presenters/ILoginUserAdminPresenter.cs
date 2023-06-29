namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters;

public interface ILoginUserAdminPresenter : ILoginUserAdminOutputPort
{
    public UserAdminTokenViewModel UserAdminTokenViewModel { get; }
}