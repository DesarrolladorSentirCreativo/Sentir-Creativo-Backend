namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins
{
    public interface ILoginUsuarioAdminPresenter : ILoginUsuarioAdminOutputPort
    {
        LoginUsuarioAdminViewModel ViewModel { get; }
    }
}
