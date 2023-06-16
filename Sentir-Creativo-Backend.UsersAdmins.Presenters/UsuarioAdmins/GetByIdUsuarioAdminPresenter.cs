using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.UsuarioAdmins;

public class GetByIdUsuarioAdminPresenter : IGetByIdUsuarioAdminPresenter
{
    public ValueTask Handle(GetByIdUsuarioAdminViewModel viewModel)
    {
        ViewModel = viewModel;
        
        return new ValueTask();
    }

    public GetByIdUsuarioAdminViewModel ViewModel { get; private set; }
}