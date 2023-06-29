namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

public interface ISelectUsuarioAdminPresenter : ISelectUsuarioAdminOutputPort
{
    IReadOnlyList<SelectUsuarioAdminViewModel> ViewModels { get; }
}