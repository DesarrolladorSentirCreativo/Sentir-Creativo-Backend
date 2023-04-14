using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Services;

public interface ICreateAudienciaService
{
    ValueTask Handle(CreateAudienciaViewModel viewModel);
}