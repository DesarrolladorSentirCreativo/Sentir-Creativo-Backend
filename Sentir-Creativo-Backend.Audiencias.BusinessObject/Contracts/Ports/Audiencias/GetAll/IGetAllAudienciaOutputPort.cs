using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetAll;

public interface IGetAllAudienciaOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllAudienciaViewModel> viewModel);
}