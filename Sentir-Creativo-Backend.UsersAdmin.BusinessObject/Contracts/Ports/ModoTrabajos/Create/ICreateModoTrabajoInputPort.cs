namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Create;

public interface ICreateModoTrabajoInputPort
{
    ValueTask Handle(CreateModoTrabajoDto dto);
}