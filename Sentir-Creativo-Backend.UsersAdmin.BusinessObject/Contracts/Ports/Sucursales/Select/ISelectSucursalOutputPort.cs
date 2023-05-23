using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Select;

public interface ISelectSucursalOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectSucursalViewModel> modelViews);
}