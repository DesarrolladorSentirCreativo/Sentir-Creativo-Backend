using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;

public interface IGetAllOrganizacionController
{
    ValueTask<IReadOnlyList<GetAllOrganizacionViewModel>> Handle();
}