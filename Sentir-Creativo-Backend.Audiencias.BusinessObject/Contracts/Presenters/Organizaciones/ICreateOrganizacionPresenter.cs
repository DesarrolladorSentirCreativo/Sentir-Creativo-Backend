using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Create;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;

public interface ICreateOrganizacionPresenter : ICreateOrganizacionOutputPort
{
    int OrganizacionId { get; }
}