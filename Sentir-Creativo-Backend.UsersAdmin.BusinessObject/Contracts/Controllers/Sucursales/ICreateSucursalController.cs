using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;

public interface ICreateSucursalController
{
    ValueTask<int> Handle(CreateSucursalDto dto);
}