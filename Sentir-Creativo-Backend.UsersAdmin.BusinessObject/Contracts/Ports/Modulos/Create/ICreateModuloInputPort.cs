using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Create;

public interface ICreateModuloInputPort
{
    ValueTask Handle(CreateModuloDto dto);
}