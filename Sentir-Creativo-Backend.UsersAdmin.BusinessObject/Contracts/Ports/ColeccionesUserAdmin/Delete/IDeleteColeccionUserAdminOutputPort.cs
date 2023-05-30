namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Delete;

public interface IDeleteColeccionUserAdminOutputPort
{
    ValueTask Handle(int coleccionUserAdminId);
}