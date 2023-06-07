using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Update;

public interface IUpdateAcuerdoUserAdminInputPort
{
    ValueTask Handle(UpdateAcuerdoUserAdminDto dto);
}