namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;

public interface ISelectSucursalController
{
    ValueTask<IReadOnlyList<SelectSucursalViewModel>> Handle();
}