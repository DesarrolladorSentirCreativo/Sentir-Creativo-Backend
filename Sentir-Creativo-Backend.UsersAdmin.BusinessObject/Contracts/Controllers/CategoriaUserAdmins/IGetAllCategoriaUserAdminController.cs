namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;

public interface IGetAllCategoriaUserAdminController
{
    ValueTask<IReadOnlyList<GetAllCategoriaUserAdminViewModel>> Handle();
}