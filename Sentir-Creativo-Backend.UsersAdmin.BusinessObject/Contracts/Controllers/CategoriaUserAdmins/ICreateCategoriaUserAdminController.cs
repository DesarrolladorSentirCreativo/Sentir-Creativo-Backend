using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;

public interface ICreateCategoriaUserAdminController
{
    ValueTask<int> Handle(CreateCategoriaUserAdminDto dto);
}