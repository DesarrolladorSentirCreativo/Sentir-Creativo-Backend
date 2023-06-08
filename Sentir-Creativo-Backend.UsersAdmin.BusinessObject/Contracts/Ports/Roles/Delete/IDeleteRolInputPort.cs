namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Delete;

public interface IDeleteRolInputPort
{
    ValueTask Handle(int rolId);
}