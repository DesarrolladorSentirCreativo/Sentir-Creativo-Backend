using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Create;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas
{
    public interface ICreateTecnicaArtisticaPresenter : ICreateTecnicaArtisticaOutputPort
    {
        int TecnicaArtisticaId { get; }
    }
}
