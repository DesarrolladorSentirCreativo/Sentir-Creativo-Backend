namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;

public interface IGetAllCategoriaUserAdminPresenter : IGetAllCategoriaUserAdminOutputPort
{
    IReadOnlyList<GetAllCategoriaUserAdminViewModel> ModelViews { get; }
}