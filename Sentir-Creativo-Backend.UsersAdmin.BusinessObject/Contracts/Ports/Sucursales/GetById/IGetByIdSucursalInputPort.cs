namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetById;

public interface IGetByIdSucursalInputPort
{
    ValueTask Handle(int sucursalId);
}