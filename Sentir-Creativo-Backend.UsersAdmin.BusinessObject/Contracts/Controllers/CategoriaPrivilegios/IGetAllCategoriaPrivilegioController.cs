using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;

public interface IGetAllCategoriaPrivilegioController
{
    ValueTask<IReadOnlyList<GetAllCategoriaPrivilegioViewModel>> Handle();
}