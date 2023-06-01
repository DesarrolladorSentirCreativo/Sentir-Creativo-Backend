using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Privilegios;

public class GetAllPrivilegioPresenter : IGetAllPrivilegioPresenter
{
    public IReadOnlyList<GetAllPrivilegioViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<GetAllPrivilegioViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}