namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;

public interface IDeleteAudienciaController
{
    ValueTask<int> Handle(int audienciaId);
}