namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;

public interface IUpdateColeccionUserAdminController
{
    ValueTask<int> Handle(UpdateColeccionUserAdminDto dto);
}