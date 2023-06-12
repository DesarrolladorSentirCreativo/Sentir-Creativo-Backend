using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.AFP;

public class GetByIdAfpPresenter : IGetByIdAfpPresenter
{
    public ValueTask Handle(GetByIdAfpViewModel viewModel)
    {
        ViewModel = viewModel;
        
        return ValueTask.CompletedTask;
    }

    public GetByIdAfpViewModel ViewModel { get; private set; }
}