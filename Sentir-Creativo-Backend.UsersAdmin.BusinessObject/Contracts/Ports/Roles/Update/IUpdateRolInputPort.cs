using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Update;

public interface IUpdateRolInputPort
{
    ValueTask Handle(UpdateRolDto dto);
}