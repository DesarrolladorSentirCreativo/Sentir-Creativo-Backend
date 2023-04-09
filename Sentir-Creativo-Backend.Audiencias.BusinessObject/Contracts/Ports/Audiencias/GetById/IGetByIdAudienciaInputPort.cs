namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetById;

public interface IGetByIdAudienciaInputPort
{
    ValueTask Handle(int audienciaId);
}