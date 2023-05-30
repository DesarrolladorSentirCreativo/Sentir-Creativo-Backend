namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Update;

public interface IUpdateColeccionUserAdminOutputPort
{
    ValueTask Handle(int coleccionUserAdminId);
}