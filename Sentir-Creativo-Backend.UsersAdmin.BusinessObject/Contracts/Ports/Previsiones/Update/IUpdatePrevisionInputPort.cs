namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Update;

public interface IUpdatePrevisionInputPort
{
    ValueTask Handle(UpdatePrevisionDto dto);
}