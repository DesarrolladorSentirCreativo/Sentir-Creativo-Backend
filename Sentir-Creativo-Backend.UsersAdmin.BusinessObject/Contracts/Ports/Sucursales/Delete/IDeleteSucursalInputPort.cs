namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Delete;

public interface IDeleteSucursalInputPort
{
    ValueTask Handle(int sucursalId);
}