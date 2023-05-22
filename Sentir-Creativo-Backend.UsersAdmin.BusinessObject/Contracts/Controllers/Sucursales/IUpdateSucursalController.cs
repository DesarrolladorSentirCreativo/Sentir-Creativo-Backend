using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;

public interface IUpdateSucursalController
{
    ValueTask<int> Handle(UpdateSucursalDto dto);
}