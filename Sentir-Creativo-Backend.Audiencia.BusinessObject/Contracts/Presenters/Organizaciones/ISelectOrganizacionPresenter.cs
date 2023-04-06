using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;

public interface ISelectOrganizacionPresenter : ISelectOrganizacionOutputPort
{
    IReadOnlyList<SelectOrganizacionViewModel> SelectOrganizacionViewModel { get; }
}