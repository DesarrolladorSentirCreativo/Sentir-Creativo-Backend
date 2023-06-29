namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;

public interface IUpdateEstadoUserAdminController
{
    ValueTask<int> Handle(UpdateEstadoUserAdminDto dto);
}