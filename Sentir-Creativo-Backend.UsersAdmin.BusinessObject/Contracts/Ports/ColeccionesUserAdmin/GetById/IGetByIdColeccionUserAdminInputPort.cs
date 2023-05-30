namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.GetById;

public interface IGetByIdColeccionUserAdminInputPort
{
    ValueTask Handle(int coleccionUserAdminId);
}