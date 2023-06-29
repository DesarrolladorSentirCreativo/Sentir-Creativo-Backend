namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;

public interface IGetAllSucursalPresenter : IGetAllSucursalOutputPort
{
    IReadOnlyList<GetAllSucursalViewModel> ModelViews { get; }
}