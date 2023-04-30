namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;

public interface IDeleteOrganizacionController
{
    ValueTask<int> Handle(int organizacionId);
}