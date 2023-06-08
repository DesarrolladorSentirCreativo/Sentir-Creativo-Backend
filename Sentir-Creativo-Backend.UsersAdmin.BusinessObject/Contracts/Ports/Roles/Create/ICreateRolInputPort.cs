using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Create;

public interface ICreateRolInputPort
{
    ValueTask Handle(CreateRolDto dto);
}