using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Delete;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas
{
    public interface IDeleteTecnicaArtisticaPresenter : IDeleteTecnicaArtisticaOutputPort
    {
        int TecnicaArtisticaId { get; }
    }
}
