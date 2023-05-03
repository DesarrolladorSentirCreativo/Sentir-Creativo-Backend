using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Update;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;

public interface IUpdateOrganizacionPresenter : IUpdateOrganizacionOutputPort
{
    int OrganizacionId { get; }
}