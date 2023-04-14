namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Create;

public interface ICreateAudienciaOutputPort
{
    ValueTask Handle(int audienciaId);
}