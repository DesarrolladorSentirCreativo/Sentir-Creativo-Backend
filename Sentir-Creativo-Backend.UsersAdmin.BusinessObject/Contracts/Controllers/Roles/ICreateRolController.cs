namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;

public interface ICreateRolController
{
    ValueTask<int> Handle(CreateRolDto dto);
}