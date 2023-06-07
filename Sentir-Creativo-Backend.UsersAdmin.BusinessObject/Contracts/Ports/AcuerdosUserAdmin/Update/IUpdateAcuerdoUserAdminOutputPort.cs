namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Update;

public interface IUpdateAcuerdoUserAdminOutputPort
{
    ValueTask Handle(int acuerdoId);
}