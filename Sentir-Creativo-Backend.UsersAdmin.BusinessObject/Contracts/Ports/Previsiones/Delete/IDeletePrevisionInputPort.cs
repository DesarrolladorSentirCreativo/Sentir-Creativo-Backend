namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Delete;

public interface IDeletePrevisionInputPort
{
    ValueTask Handle(int previsionId);
}