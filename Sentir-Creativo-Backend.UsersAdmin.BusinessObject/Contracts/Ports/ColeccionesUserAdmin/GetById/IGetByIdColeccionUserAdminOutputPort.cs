namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.GetById;

public interface IGetByIdColeccionUserAdminOutputPort
{
    ValueTask Handle(GetByIdColeccionUserAdminViewModel getByIdColeccionUserAdminViewModel);
}