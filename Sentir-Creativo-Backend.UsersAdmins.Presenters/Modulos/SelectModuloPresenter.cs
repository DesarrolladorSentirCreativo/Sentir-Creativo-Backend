using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Modulos;

public class SelectModuloPresenter : ISelectModuloPresenter
{
    public IReadOnlyList<SelectModuloViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectModuloViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}