using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Delete;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;

namespace Sentir_Creativo_Backend.Servicios.Controllers.TecnicaArtisticas
{
    public class DeleteTecnicaArtisticaController : IDeleteTecnicaArtisitcaController
    {
        private readonly IDeleteTecnicaArtisticaPresenter _presenter;
        private readonly IDeleteTecnicaArtisticaInputPort _inputPort;

        public DeleteTecnicaArtisticaController(
            IDeleteTecnicaArtisticaPresenter presenter,
            IDeleteTecnicaArtisticaInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<int> Handle(int tecnicaArtisticaId)
        {
            await _inputPort.Handle(tecnicaArtisticaId);

            return _presenter.TecnicaArtisticaId;
        }
    }
}
