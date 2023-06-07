using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Create;

public interface ICreateAcuerdoUserAdminInputPort
{
    ValueTask Handle(CreateAcuerdoUserAdminDto dto);
}