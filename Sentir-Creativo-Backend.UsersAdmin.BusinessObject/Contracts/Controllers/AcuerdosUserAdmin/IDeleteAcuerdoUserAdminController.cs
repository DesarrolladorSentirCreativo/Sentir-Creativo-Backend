namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;

public interface IDeleteAcuerdoUserAdminController
{
    ValueTask<int> Handle(int acuerdoId);
}