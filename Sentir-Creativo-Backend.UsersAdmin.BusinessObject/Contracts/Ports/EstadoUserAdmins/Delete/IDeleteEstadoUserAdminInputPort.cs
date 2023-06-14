namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Delete;

public interface IDeleteEstadoUserAdminInputPort
{
    ValueTask Handle(int estadoId);
}