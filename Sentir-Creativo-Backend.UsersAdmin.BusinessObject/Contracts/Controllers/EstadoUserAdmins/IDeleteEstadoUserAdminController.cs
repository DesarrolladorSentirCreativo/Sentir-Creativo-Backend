namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;

public interface IDeleteEstadoUserAdminController
{
    ValueTask<int> Handle(int estadoId);
}