namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Delete;

public interface IDeleteAcuerdoUserAdminInputPort
{
    ValueTask Handle(int acuerdoId);
}