namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;

public interface IGetByIdSucursalPresenter : IGetByIdSucursalOutputPort
{
    GetByIdSucursalViewModel ModelView { get; }
}