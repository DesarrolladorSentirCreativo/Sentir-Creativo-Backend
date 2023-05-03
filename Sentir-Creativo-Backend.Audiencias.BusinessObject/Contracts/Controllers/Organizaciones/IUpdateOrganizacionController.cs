using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;

public interface IUpdateOrganizacionController
{
    ValueTask<int> Handle(UpdateOrganizacionDto dto);
}