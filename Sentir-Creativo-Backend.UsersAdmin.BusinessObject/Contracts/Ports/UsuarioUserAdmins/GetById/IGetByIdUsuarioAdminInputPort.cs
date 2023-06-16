using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.GetById;

public interface IGetByIdUsuarioAdminInputPort
{
    ValueTask Handle(int usuarioAdminId);
}