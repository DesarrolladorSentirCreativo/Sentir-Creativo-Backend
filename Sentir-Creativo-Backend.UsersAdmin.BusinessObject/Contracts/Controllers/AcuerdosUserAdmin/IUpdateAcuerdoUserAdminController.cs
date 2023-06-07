using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;

public interface IUpdateAcuerdoUserAdminController
{
    ValueTask<int> Handle(UpdateAcuerdoUserAdminDto dto);
}