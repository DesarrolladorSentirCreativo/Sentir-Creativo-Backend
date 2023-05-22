namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Delete;

public interface IDeleteSucursalOutputPort
{
    ValueTask Handle(int sucursalId);
}