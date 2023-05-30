namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Delete;

public interface IDeleteColeccionUserAdminInputPort
{
    ValueTask Handle(int coleccionUserAdminId);
}