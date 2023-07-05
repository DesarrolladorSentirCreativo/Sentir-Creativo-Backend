using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.Presenters.TecnicaArtisticas
{
    public class SelectTecnicaArtisticaPresenter : ISelectTecnicaArtisticaPresenter
    {
        public IReadOnlyList<SelectTecnicaArtisticaViewModel> ModelViews { get; private set; }

        public ValueTask Handle(IReadOnlyList<SelectTecnicaArtisticaViewModel> modelViews)
        {
            ModelViews = modelViews;

            return ValueTask.CompletedTask;
        }
    }
}
