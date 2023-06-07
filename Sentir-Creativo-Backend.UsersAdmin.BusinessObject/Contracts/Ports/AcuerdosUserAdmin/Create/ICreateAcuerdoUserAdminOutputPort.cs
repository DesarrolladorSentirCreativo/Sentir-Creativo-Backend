namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Create;

public interface ICreateAcuerdoUserAdminOutputPort
{
    ValueTask Handle(int acuerdoId);
}