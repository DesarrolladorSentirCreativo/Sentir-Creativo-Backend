using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;

public interface ISelectColeccionUserAdminController
{
    ValueTask<IReadOnlyList<SelectColeccionUserAdminViewModel>> Handle();
}