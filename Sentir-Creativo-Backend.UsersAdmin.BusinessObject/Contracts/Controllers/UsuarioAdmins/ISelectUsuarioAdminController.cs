namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;

public interface ISelectUsuarioAdminController
{
    ValueTask<IReadOnlyList<SelectUsuarioAdminViewModel>> Handle();
}