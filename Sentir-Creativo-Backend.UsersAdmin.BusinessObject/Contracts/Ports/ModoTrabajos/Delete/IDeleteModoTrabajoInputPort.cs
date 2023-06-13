namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Delete;

public interface IDeleteModoTrabajoInputPort
{
    ValueTask Handle(int modoTrabajoId);
}