namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetById;

public interface IGetByIdRolOutputPort
{
    ValueTask Handle(GetByIdRolViewModel modelView);
}