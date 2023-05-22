namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;

public interface IDeleteSucursalController
{
    ValueTask<int> Handle(int sucursalId);
}