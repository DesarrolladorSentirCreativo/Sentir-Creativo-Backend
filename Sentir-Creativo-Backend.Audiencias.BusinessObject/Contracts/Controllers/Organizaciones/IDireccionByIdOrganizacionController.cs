using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;

public interface IDireccionByIdOrganizacionController
{
    ValueTask<DireccionByIdOrganizacionViewModel> Handle(int organizacionId);
}