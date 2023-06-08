namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Update;

public interface IUpdateRolOutputPort
{
    ValueTask Handle(int rolId);
}