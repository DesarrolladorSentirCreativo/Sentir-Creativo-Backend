namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Delete;

public interface IDeleteRolOutputPort
{
    ValueTask Handle(int rolId);
}