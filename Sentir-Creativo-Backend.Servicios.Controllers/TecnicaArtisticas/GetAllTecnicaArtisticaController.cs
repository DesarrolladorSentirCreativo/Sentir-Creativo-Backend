using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetAll;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.Controllers.TecnicaArtisticas
{
    public class GetAllTecnicaArtisticaController : IGetAllTecnicaArtisticaController
    {
        private readonly IGetAllTecnicaArtisticaPresenter _presenter;
        private readonly IGetAllTecnicaArtisticaInputPort _inputPort;

        public GetAllTecnicaArtisticaController(
            IGetAllTecnicaArtisticaPresenter presenter,
            IGetAllTecnicaArtisticaInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<IReadOnlyList<GetAllTecnicaArtisticaViewModel>> Handle()
        {
            await _inputPort.Handle();

            return _presenter.ModelViews;
        }
    }
}
