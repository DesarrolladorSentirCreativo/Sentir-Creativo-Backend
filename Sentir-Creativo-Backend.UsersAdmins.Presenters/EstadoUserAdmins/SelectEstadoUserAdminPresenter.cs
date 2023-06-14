using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.EstadoUserAdmins;

public class SelectEstadoUserAdminPresenter : ISelectEstadoUserAdminPresenter
{
    public ValueTask Handle(IReadOnlyList<SelectEstadoUserAdminViewModel> viewModels)
    {
        ViewModels = viewModels;
        
        return ValueTask.CompletedTask;
    }

    public IReadOnlyList<SelectEstadoUserAdminViewModel> ViewModels { get; private set; }
}