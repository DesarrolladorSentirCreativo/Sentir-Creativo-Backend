namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;

public interface ICreateSucursalPresenter : ICreateSucursalOutputPort
{
    int SucursalId { get; }
}