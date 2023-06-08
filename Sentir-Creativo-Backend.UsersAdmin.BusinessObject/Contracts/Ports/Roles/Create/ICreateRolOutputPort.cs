namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Create;

public interface ICreateRolOutputPort
{
    ValueTask Handle(int rolId);
}