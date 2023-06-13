namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Delete;

public interface IDeleteModoTrabajoOutputPort
{
    ValueTask Handle(int modoTrabajoId);
}