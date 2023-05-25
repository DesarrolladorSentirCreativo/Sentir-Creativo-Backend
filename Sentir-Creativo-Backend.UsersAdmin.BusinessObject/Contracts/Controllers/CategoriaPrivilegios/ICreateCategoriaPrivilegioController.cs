using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;

public interface ICreateCategoriaPrivilegioController
{
    ValueTask<int> Handle(CreateCategoriaPrivilegioDto dto);
}