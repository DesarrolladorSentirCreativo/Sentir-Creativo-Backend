namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;

public interface IGetByIdRolController
{
    ValueTask<GetByIdRolViewModel> Handle(int rolId);
}