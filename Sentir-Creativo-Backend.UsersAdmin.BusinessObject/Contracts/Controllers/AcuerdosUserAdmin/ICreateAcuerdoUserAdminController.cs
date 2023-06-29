namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;

public interface ICreateAcuerdoUserAdminController
{
    ValueTask<int> Handle(CreateAcuerdoUserAdminDto dto);
}