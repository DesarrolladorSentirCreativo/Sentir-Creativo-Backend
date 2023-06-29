namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;

public interface ICreateSucursalInputPort
{
    ValueTask Handle(CreateSucursalDto dto);
}