namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;

public interface IUpdateCategoriaUserAdminController
{
    ValueTask<int> Handle(UpdateCategoriaUserAdminDto dto);
}