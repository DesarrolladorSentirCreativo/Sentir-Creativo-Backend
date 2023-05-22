using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;

public interface IUpdateSucursalPresenter : IUpdateSucursalOutputPort
{
    int SucursalId { get; }
}