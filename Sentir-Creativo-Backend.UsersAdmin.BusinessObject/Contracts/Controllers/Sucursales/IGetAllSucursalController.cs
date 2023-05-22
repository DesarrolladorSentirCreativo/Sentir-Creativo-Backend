using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;

public interface IGetAllSucursalController
{
    ValueTask<IReadOnlyList<GetAllSucursalViewModel>> Handle();
}