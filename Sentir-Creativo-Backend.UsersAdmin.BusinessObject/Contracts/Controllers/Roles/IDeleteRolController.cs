namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;

public interface IDeleteRolController
{
    ValueTask<int> Handle(int rolId);
}