namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Create;

public interface ICreateEstadoUserAdminOutputPort
{
    ValueTask Handle(int estadoId);
}