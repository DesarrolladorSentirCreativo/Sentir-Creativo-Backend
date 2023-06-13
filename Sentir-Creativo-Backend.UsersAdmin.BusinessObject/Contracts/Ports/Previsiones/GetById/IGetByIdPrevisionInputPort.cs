namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.GetById;

public interface IGetByIdPrevisionInputPort
{
    ValueTask Handle(int previsionId);
}