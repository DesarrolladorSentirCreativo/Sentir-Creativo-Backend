namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

public interface IGetAllUsuarioAdminPresenter : IGetAllUsuarioAdminOutputPort
{
    IReadOnlyList<GetAllUsuarioAdminViewModel> ViewModels { get; }
}