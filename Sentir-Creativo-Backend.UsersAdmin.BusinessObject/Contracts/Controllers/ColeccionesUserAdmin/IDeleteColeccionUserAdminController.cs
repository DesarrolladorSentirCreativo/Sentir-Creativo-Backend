namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;

public interface IDeleteColeccionUserAdminController
{
    ValueTask<int> Handle(int coleccionUserAdminId);
}