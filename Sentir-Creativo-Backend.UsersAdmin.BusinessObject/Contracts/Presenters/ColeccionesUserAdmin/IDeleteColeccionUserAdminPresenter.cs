using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Delete;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

public interface IDeleteColeccionUserAdminPresenter : IDeleteColeccionUserAdminOutputPort
{
    int ColeccionUserAdminId { get; }
}