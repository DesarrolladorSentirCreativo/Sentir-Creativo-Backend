using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.GetAll;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;

public interface IGetAllOrganizacionPresenter : IGetAllOrganizacionOutputPort
{
    IReadOnlyList<GetAllOrganizacionViewModel> GetAllOrganizaciones { get; }
}