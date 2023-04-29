using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Organizaciones;

public class GetAllOrganizacionPresenter : IGetAllOrganizacionPresenter
{
    public IReadOnlyList<GetAllOrganizacionViewModel> GetAllOrganizaciones { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<GetAllOrganizacionViewModel> viewModels)
    {
        GetAllOrganizaciones = viewModels;
        
        return ValueTask.CompletedTask;
    }
}