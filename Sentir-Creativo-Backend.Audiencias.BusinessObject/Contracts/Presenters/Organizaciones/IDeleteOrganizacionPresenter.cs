using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Delete;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;

public interface IDeleteOrganizacionPresenter : IDeleteOrganizacionOutputPort
{
    int OrganizacionId { get; }
}