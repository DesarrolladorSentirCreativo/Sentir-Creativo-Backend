using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Select;

public interface ISelectEstadoUserAdminOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectEstadoUserAdminViewModel> viewModels);
}