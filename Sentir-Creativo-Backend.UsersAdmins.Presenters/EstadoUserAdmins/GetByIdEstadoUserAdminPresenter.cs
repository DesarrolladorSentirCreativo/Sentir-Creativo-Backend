using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.EstadoUserAdmins;

public class GetByIdEstadoUserAdminPresenter : IGetByIdEstadoUserAdminPresenter
{
    public ValueTask Handle(GetByIdEstadoUserAdminViewModel viewModel)
    {
        ViewModel = viewModel;
        
        return ValueTask.CompletedTask;
    }

    public GetByIdEstadoUserAdminViewModel ViewModel { get; private set; }
}