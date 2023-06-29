namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;

public interface IGetByIdCategoriaUserAdminController
{
    ValueTask<GetByIdCategoriaUserAdminViewModel> Handle(int categoriaId);
}