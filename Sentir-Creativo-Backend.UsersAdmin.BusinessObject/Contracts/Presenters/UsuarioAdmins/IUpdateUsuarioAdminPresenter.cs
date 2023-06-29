namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

public interface IUpdateUsuarioAdminPresenter : IUpdateUsuarioAdminOutputPort
{
    int UsuarioAdminId { get; }
}