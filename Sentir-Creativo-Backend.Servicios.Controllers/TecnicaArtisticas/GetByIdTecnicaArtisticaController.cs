using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetById;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.Controllers.TecnicaArtisticas
{
    public class GetByIdTecnicaArtisticaController : IGetByIdTecnicaArtisticaController
    {
        private readonly IGetByIdTecnicaArtisticaPresenter _presenter;
        private readonly IGetByIdTecnicaArtisticaInputPort _inputPort;

        public GetByIdTecnicaArtisticaController(
            IGetByIdTecnicaArtisticaPresenter presenter,
            IGetByIdTecnicaArtisticaInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<GetByIdTecnicaArtisticaViewModel> Handle(int tecnicaArtisticaId)
        {
            await _inputPort.Handle(tecnicaArtisticaId);

            return _presenter.ViewModel;
        }
    }
}
