using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Select;

public interface ISelectOrganizacionOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectOrganizacionViewModel> modelView);
}