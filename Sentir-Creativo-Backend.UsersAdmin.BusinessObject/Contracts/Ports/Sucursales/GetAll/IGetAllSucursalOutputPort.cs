namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetAll;

public interface IGetAllSucursalOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllSucursalViewModel> modelViews);
}