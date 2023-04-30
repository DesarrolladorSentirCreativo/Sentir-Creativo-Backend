namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Create;

public interface ICreateOrganizacionOutputPort
{
    ValueTask Handle(int organizacionId);
}