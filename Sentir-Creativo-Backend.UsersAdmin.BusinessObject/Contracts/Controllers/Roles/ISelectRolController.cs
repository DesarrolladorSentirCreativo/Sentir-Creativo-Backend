namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;

public interface ISelectRolController
{
    ValueTask<IReadOnlyList<SelectRolViewModel>> Handle();
}