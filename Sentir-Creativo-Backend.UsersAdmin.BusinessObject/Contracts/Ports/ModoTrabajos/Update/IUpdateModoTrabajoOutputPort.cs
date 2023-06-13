namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Update;

public interface IUpdateModoTrabajoOutputPort
{
    ValueTask Handle(int modoTrabajoId);
}