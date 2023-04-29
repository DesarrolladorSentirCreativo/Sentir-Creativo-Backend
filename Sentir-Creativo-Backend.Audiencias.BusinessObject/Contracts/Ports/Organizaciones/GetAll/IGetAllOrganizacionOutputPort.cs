using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.GetAll;

public interface IGetAllOrganizacionOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllOrganizacionViewModel> viewModels);
}