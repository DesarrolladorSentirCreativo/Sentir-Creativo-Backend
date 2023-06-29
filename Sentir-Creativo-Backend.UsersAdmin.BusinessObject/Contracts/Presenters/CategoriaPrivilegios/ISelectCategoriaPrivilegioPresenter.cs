namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;

public interface ISelectCategoriaPrivilegioPresenter : ISelectCategoriaPrivilegioOutputPort
{
    IReadOnlyList<SelectCategoriaPrivilegioViewModel> ModelViews { get; }
}