namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;

public interface IUpdateCategoriaUserAdminPresenter : IUpdateCategoriaUserAdminOutputPort
{
    int CategoriaId { get; }
}