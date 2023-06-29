namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

public interface IGetByIdUsuarioAdminPresenter : IGetByIdUsuarioAdminOutputPort
{
    GetByIdUsuarioAdminViewModel ViewModel { get; }
}