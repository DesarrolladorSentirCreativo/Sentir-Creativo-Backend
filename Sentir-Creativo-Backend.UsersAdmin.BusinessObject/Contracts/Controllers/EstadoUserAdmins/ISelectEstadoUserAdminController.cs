using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;

public interface ISelectEstadoUserAdminController
{
    ValueTask<IReadOnlyList<SelectEstadoUserAdminViewModel>> Handle();
}