namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Update;

public interface IUpdatePrevisionOutputPort
{
    ValueTask Handle(int previsionId);
}