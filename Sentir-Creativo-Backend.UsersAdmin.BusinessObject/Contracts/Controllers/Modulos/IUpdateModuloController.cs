using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;

public interface IUpdateModuloController
{
    ValueTask<int> Handle(UpdateModuloDto dto);
}