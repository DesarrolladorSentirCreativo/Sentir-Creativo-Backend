namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;

public interface IGetAllAcuerdoUserAdminController
{
    ValueTask<IReadOnlyList<GetAllAcuerdoUserAdminViewModel>> Handle();
}