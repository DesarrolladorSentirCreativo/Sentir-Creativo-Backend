using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.Presenters.TecnicaArtisticas
{
    public class GetByIdTecnicaArtisticaPresenter : IGetByIdTecnicaArtisticaPresenter
    {
        public GetByIdTecnicaArtisticaViewModel ViewModel { get; private set; }

        public ValueTask Handle(GetByIdTecnicaArtisticaViewModel viewModel)
        {
            ViewModel = viewModel;

            return ValueTask.CompletedTask;
        }
    }
}
