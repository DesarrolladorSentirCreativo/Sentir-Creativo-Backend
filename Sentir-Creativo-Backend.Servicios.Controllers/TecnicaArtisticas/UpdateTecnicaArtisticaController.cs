using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Update;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.TecnicaArtisticas;

namespace Sentir_Creativo_Backend.Servicios.Controllers.TecnicaArtisticas
{
    public class UpdateTecnicaArtisticaController : IUpdateTecnicaArtisticaController
    {
        private readonly IUpdateTecnicaArtisticaPresenter _presenter;
        private readonly IUpdateTecnicaArtisticaInputPort _inputPort;

        public UpdateTecnicaArtisticaController(
            IUpdateTecnicaArtisticaPresenter presenter,
            IUpdateTecnicaArtisticaInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<int> Handle(UpdateTecnicaArtisticaDto dto)
        {
            await _inputPort.Handle(dto);

            return _presenter.TecnicaArtisticaId;
        }
    }
}
