using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Organizaciones;

public class CreateOrganizacionPresenter : ICreateOrganizacionPresenter
{
    public int OrganizacionId { get; private set; }
    
    public ValueTask Handle(int organizacionId)
    {
        OrganizacionId = organizacionId;

        return ValueTask.CompletedTask;
    }
}