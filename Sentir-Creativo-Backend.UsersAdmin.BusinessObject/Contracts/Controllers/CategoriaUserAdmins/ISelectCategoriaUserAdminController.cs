namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;

public interface ISelectCategoriaUserAdminController
{
    ValueTask<IReadOnlyList<SelectCategoriaUserAdminViewModel>> Handle();
}