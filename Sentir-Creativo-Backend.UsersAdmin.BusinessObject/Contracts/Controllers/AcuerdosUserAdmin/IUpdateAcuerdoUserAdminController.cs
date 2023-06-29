namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;

public interface IUpdateAcuerdoUserAdminController
{
    ValueTask<int> Handle(UpdateAcuerdoUserAdminDto dto);
}