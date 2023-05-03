namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.DireccionById;

public interface IDireccionByIdOrganizacionInputPort
{
    ValueTask Handle(int organizacionId);
}