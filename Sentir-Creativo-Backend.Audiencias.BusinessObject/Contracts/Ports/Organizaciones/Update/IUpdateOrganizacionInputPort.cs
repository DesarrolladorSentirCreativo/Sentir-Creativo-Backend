using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Update;

public interface IUpdateOrganizacionInputPort
{
    ValueTask Handle(UpdateOrganizacionDto dto);
}