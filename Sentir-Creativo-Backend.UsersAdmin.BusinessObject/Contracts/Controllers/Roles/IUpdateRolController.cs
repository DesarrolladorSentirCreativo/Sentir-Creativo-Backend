namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;

public interface IUpdateRolController
{
    ValueTask<int> Handle(UpdateRolDto dto);
}