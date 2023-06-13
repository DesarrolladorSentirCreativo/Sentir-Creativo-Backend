namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Delete;

public interface IDeletePrevisionOutputPort
{
    ValueTask Handle(int previsionId);
}