namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Update;

public interface IUpdateRolInputPort
{
    ValueTask Handle(UpdateRolDto dto);
}