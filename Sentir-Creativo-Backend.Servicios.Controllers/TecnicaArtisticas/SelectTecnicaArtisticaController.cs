using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.Controllers.TecnicaArtisticas
{
    public class SelectTecnicaArtisticaController : ISelectTecnicaArtisticaController
    {
        private readonly ISelectTecnicaArtisticaPresenter _presenter;
        private readonly ISelectTecnicaArtisticaInputPort _inputPort;

        public SelectTecnicaArtisticaController(ISelectTecnicaArtisticaPresenter presenter, ISelectTecnicaArtisticaInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<IReadOnlyList<SelectTecnicaArtisticaViewModel>> Handle()
        {
            await _inputPort.Handle();

            return _presenter.ModelViews;
        }
    }
}
