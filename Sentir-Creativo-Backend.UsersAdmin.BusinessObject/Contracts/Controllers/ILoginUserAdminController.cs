using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers;

public interface ILoginUserAdminController
{
    ValueTask<UserAdminTokenViewModel> Handle(LoginUserAdminDto dto);
}