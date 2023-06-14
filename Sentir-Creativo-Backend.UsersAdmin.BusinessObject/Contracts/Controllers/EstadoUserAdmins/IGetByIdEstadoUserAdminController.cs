using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;

public interface IGetByIdEstadoUserAdminController
{
    ValueTask<GetByIdEstadoUserAdminViewModel> Handle(int estadoId);
}