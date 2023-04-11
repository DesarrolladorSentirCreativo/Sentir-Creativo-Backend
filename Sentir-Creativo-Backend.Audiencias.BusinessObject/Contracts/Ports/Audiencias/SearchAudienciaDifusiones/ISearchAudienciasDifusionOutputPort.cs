using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.SearchAudienciaDifusiones;

public interface ISearchAudienciasDifusionOutputPort
{
    ValueTask Handle(SearchAudienciasDifusionViewModel modelView);
}