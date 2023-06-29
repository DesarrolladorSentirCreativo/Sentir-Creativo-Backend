namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;

public interface ISelectSucursalPresenter : ISelectSucursalOutputPort
{
    IReadOnlyList<SelectSucursalViewModel> ModelViews { get; }
}