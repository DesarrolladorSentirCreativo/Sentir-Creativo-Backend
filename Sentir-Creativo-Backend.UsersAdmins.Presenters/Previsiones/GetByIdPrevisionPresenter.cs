using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Previsiones;

public class GetByIdPrevisionPresenter : IGetByIdPrevisionPresenter
{
    public ValueTask Handle(GetByIdPrevisionViewModel viewModel)
    {
        ViewModel = viewModel;
        
        return ValueTask.CompletedTask;
    }

    public GetByIdPrevisionViewModel ViewModel { get; private set; }
}