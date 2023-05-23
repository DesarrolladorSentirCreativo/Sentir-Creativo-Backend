using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;

public interface ISelectSucursalPresenter : ISelectSucursalOutputPort
{
    IReadOnlyList<SelectSucursalViewModel> ModelViews { get; }
}