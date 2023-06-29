namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

public interface ISelectCategoriaUserAdminPresenter : ISelectCategoriaUserAdminOutputPort
{
    IReadOnlyList<SelectCategoriaUserAdminViewModel> ViewModels { get; }
}