namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Create;

public interface ICreatePrevisionInputPort
{
    ValueTask Handle(CreatePrevisionDto dto);
}