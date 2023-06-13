namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Create;

public interface ICreateModoTrabajoOutputPort
{
    ValueTask Handle(int modoTrabajoId);
}