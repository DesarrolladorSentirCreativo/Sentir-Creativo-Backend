using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Update;

public interface IUpdateEstadoUserAdminInputPort
{
    ValueTask Handle(UpdateEstadoUserAdminDto dto);
}