using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;

namespace Sentir_Creativo_Backend.Servicios.Presenters.TecnicaArtisticas
{
    public class DeleteTecnicaArtisticaPresenter : IDeleteTecnicaArtisticaPresenter
    {
        public int TecnicaArtisticaId { get; private set; }

        public ValueTask Handle(int tecnicaArtisticaId)
        {
            TecnicaArtisticaId = tecnicaArtisticaId;

            return ValueTask.CompletedTask;
        }
    }
}
