using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.DireccionById;

public interface IDireccionByIdOrganizacionOutputPort
{
    ValueTask Handle(DireccionByIdOrganizacionViewModel modelView);
}