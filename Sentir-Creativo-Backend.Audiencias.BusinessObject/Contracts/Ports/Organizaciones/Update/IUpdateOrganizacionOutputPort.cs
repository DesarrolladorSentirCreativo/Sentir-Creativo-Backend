namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Update;

public interface IUpdateOrganizacionOutputPort
{
    ValueTask Handle(int organizacionId);
}