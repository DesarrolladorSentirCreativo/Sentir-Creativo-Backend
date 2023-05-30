using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Create;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

public interface ICreateColeccionUserAdminPresenter : ICreateColeccionUserAdminOutputPort
{
    int ColeccionUserAdminId { get; }
}