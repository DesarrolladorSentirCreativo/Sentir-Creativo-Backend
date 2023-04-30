namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Delete;

public interface IDeleteOrganizacionOutputPort
{
    ValueTask Handle(int organizacionId);
}