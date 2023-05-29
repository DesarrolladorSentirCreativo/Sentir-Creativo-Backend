using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Update;

public interface IUpdateModuloInputPort
{
    ValueTask Handle(UpdateModuloDto dto);
}