namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Delete;

public interface IDeleteEstadoUserAdminOutputPort
{
    ValueTask Handle(int estadoId);
}