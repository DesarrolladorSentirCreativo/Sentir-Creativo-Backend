using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Delete;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;

public interface IDeleteSucursalPresenter : IDeleteSucursalOutputPort
{
    int SucursalId { get; }
}