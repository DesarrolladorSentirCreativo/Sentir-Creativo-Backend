namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;

public interface IDeleteCategoriaUserAdminPresenter : IDeleteCategoriaUserAdminOutputPort
{
    int CategoriaId { get; }
}