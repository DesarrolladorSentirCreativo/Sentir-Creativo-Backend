using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

public interface IGetAllColeccionUserAdminPresenter : IGetAllColeccionUserAdminOutputPort
{
    IReadOnlyList<GetAllColeccionUserAdminViewModel> ModelViews { get; }
}