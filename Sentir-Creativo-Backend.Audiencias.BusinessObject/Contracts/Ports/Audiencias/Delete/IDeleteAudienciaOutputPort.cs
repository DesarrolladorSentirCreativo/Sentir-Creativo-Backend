namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Delete;

public interface IDeleteAudienciaOutputPort
{
    ValueTask Handle(int audienciaId);
}