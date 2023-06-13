namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Create;

public interface ICreatePrevisionOutputPort
{
    ValueTask Handle(int previsionId);
}