namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Delete;

public interface IDeleteOrganizacionInputPort
{
    ValueTask Handle(int organizacionId);
}