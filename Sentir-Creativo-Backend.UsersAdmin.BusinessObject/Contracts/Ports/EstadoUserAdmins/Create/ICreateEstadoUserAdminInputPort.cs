namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Create;

public interface ICreateEstadoUserAdminInputPort
{
    ValueTask Handle(CreateEstadoUserAdminDto dto);
    
}