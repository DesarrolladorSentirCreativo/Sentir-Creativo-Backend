namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;

public interface IGetAllEstadoUserAdminController
{
    ValueTask<IReadOnlyList<GetAllEstadoUserAdminViewModel>> Handle();
}