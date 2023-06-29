namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;

public interface IGetByIdAcuerdoUserAdminControiller
{
    ValueTask<GetByIdAcuerdoUserAdminViewModel> Handle(int acuerdoId);
}