namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;

public interface IDeleteCategoriaUserAdminController
{
    ValueTask<int> Handle(int categoriaId);
}