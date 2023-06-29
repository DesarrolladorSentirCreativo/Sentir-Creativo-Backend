namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;

public interface ISelectCategoriaPrivilegioController
{
    ValueTask<IReadOnlyList<SelectCategoriaPrivilegioViewModel>> Handle();
}