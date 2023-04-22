namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Delete;

public interface IDeleteAudienciaInputPort
{
    ValueTask Handle(int audienciaId);
}