using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.UsuarioAdmins;

public class GetAllUsuarioAdminPresenter : IGetAllUsuarioAdminPresenter
{
    public ValueTask Handle(IReadOnlyList<GetAllUsuarioAdminViewModel> viewModels)
    {
        ViewModels = viewModels;
        
        return ValueTask.CompletedTask;
    }

    public IReadOnlyList<GetAllUsuarioAdminViewModel> ViewModels { get; private set; }
}