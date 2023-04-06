using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Organizaciones;

public class SelectOrganizacionPresenter : ISelectOrganizacionPresenter
{
    public IReadOnlyList<SelectOrganizacionViewModel> SelectOrganizacionViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectOrganizacionViewModel> modelView)
    {
        SelectOrganizacionViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }
    
}