namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;

public interface ISelectAcuerdoUserAdminController
{
    ValueTask<IReadOnlyList<SelectAcuerdoUserAdminViewModel>> Handle();
}