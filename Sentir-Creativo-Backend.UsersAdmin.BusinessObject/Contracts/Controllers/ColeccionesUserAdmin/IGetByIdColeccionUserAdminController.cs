namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;

public interface IGetByIdColeccionUserAdminController
{
    ValueTask<GetByIdColeccionUserAdminViewModel> Handle(int coleccionUserAdminId);
}