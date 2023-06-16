using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.UsuarioAdmins;

public class SelectUsuarioAdminPresenter : ISelectUsuarioAdminPresenter
{
    public ValueTask Handle(IReadOnlyList<SelectUsuarioAdminViewModel> viewModels)
    {
        ViewModels = viewModels;
        
        return ValueTask.CompletedTask;
    }

    public IReadOnlyList<SelectUsuarioAdminViewModel> ViewModels { get; private set; }
}