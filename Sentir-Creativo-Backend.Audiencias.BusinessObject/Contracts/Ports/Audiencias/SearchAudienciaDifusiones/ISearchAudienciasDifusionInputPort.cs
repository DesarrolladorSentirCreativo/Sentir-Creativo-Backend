namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.SearchAudienciaDifusiones;

public interface ISearchAudienciasDifusionInputPort
{
    ValueTask Handle(int difusionId);
}