using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.GetById;

public interface IGetByIdUsuarioAdminOutputPort
{
    ValueTask Handle(GetByIdUsuarioAdminViewModel viewModel);
}