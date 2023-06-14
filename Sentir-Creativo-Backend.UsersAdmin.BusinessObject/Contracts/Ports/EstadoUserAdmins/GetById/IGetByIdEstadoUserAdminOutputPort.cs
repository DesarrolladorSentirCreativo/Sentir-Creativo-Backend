using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.GetById;

public interface IGetByIdEstadoUserAdminOutputPort
{
    ValueTask Handle(GetByIdEstadoUserAdminViewModel viewModel);
}