namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetById;

public interface IGetByIdSucursalOutputPort
{
    ValueTask Handle(GetByIdSucursalViewModel modelView);
}