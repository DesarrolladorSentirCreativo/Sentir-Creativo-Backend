namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Update;

public interface IUpdateAcuerdoUserAdminInputPort
{
    ValueTask Handle(UpdateAcuerdoUserAdminDto dto);
}