namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Delete;

public interface IDeleteAcuerdoUserAdminOutputPort
{
    ValueTask Handle(int acuerdoId);
}