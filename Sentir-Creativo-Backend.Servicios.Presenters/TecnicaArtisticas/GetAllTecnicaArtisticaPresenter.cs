using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.Presenters.TecnicaArtisticas
{
    public class GetAllTecnicaArtisticaPresenter : IGetAllTecnicaArtisticaPresenter
    {
        public IReadOnlyList<GetAllTecnicaArtisticaViewModel> ModelViews { get; private set; }

        public ValueTask Handle(IReadOnlyList<GetAllTecnicaArtisticaViewModel> modelViews)
        {
            ModelViews = modelViews;

            return ValueTask.CompletedTask;

        }
    }
}
