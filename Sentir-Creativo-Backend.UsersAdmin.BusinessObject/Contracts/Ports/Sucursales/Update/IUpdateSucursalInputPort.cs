namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;

public interface IUpdateSucursalInputPort
{
    ValueTask Handle(UpdateSucursalDto dto);
}