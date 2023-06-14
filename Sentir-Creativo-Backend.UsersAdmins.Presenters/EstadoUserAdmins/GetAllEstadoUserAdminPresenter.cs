using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.EstadoUserAdmins;

public class GetAllEstadoUserAdminPresenter : IGetAllEstadoUserAdminPresenter
{
    public ValueTask Handle(IReadOnlyList<GetAllEstadoUserAdminViewModel> viewModels)
    {
        ViewModels = viewModels;
        
        return ValueTask.CompletedTask;
    }

    public IReadOnlyList<GetAllEstadoUserAdminViewModel> ViewModels { get; private set; }
}