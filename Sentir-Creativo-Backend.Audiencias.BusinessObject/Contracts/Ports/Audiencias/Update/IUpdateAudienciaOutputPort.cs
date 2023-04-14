namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Update;

public interface IUpdateAudienciaOutputPort
{
    ValueTask Handle(int audienciaId);
}