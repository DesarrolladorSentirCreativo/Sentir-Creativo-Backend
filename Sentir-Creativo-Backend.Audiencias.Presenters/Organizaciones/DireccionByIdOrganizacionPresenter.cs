using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Organizaciones;

public class DireccionByIdOrganizacionPresenter : IDireccionByIdOrganizacionPresenter
{
    public DireccionByIdOrganizacionViewModel Direccion { get; private set; }
    
    public ValueTask Handle(DireccionByIdOrganizacionViewModel modelView)
    {
        Direccion = modelView;
        
        return ValueTask.CompletedTask;
    }
}