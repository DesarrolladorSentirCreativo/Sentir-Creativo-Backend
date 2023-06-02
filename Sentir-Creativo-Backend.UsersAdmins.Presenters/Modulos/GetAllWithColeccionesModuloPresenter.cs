using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Modulos;

public class GetAllWithColeccionesModuloPresenter : IGetAllWithColeccionesModuloPresenter
{
    public IReadOnlyList<GetAllWithColeccionesModuloViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<GetAllWithColeccionesModuloViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}