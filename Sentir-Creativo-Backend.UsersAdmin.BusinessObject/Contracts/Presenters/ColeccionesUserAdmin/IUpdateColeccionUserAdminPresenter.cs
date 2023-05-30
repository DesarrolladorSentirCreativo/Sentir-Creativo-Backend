using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

public interface IUpdateColeccionUserAdminPresenter : IUpdateColeccionUserAdminOutputPort
{
    int ColeccionUserAdminId { get; }
}