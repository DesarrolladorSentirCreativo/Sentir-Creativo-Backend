namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;

public interface ICreateSucursalOutputPort
{
    ValueTask Handle(int sucursalId);
}