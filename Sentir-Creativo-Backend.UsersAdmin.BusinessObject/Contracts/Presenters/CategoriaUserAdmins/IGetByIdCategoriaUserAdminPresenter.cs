namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;

public interface IGetByIdCategoriaUserAdminPresenter : IGetByIdCategoriaUserAdminOutputPort
{
    GetByIdCategoriaUserAdminViewModel ViewModel { get; }
}