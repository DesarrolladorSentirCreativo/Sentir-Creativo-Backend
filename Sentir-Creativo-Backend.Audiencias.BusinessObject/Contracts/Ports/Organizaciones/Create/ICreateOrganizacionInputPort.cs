using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Create;

public interface ICreateOrganizacionInputPort
{
    ValueTask Handle(CreateOrganizacionDto dto);
}