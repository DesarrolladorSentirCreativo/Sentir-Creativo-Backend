namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;

public interface ICreateCategoriaUserAdminPresenter : ICreateCategoriaUserAdminOutputPort
{
    int CategoriaId { get; }
}