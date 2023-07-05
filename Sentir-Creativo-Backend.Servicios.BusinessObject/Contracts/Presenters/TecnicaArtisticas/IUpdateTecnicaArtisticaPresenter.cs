using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Update;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas
{
    public interface IUpdateTecnicaArtisticaPresenter : IUpdateTecnicaArtisticaOutputPort
    {
        int TecnicaArtisticaId { get; }
    }
}
