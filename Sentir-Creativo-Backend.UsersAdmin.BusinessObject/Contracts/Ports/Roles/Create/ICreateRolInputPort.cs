namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Create;

public interface ICreateRolInputPort
{
    ValueTask Handle(CreateRolDto dto);
}