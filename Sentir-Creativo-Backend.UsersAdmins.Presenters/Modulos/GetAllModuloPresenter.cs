using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Modulos;

public class GetAllModuloPresenter : IGetAllModuloPresenter
{
    public IReadOnlyList<GetAllModuloViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<GetAllModuloViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}