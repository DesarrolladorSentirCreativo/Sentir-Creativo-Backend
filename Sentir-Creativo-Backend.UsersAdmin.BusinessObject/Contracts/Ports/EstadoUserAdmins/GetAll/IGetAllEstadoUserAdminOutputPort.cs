using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.GetAll;

public interface IGetAllEstadoUserAdminOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllEstadoUserAdminViewModel> viewModels);
}