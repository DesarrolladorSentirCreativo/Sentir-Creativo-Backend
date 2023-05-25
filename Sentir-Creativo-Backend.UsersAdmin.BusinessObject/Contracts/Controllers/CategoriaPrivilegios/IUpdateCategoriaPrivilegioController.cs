using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;

public interface IUpdateCategoriaPrivilegioController
{
    ValueTask<int> Handle(UpdateCategoriaPrivilegioDto dto);
}