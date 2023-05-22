namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;

public interface IUpdateSucursalOutputPort
{
    ValueTask Handle(int sucursalId);
}