using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Update;

public interface IUpdatePrivilegioInputPort
{
    ValueTask Handle(UpdatePrivilegioDto dto);
}