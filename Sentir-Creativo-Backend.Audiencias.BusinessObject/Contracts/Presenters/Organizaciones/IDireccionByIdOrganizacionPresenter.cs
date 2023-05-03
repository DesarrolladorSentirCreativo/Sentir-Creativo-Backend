using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.DireccionById;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;

public interface IDireccionByIdOrganizacionPresenter : IDireccionByIdOrganizacionOutputPort
{
    DireccionByIdOrganizacionViewModel Direccion { get; }
}