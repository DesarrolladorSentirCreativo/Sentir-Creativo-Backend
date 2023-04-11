using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.SearchAudienciaDifusiones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;

public interface ISearchAudienciasDifusionPresenter : ISearchAudienciasDifusionOutputPort
{
    SearchAudienciasDifusionViewModel SearchAudienciasDifusionViewModel { get; }
}