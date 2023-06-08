namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetById;

public interface IGetByIdRolInputPort
{
    ValueTask Handle(int rolId);
}