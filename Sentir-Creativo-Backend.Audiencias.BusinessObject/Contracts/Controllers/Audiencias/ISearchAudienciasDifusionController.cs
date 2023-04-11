using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;

public interface ISearchAudienciasDifusionController
{
    ValueTask<SearchAudienciasDifusionViewModel> Handle(int difusionId);
}