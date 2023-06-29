namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;

public interface IGetAllColeccionUserAdminController
{
    ValueTask<IReadOnlyList<GetAllColeccionUserAdminViewModel>> Handle();
}