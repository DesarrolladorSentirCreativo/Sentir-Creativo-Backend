namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Create;

public interface ICreateColeccionUserAdminOutputPort
{
    ValueTask Handle(int coleccionUserAdminId);
}