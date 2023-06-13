using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Previsiones;

public class GetAllPrevisionPresenter : IGetAllPrevisionPresenter
{
    public ValueTask Handle(IReadOnlyList<GetAllPrevisionViewModel> viewModels)
    {
        ViewModels = viewModels;
        
        return ValueTask.CompletedTask;
    }

    public IReadOnlyList<GetAllPrevisionViewModel> ViewModels { get; private set; }
}