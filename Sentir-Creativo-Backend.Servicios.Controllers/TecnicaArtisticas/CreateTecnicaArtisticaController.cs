using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Create;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.TecnicaArtisticas;

namespace Sentir_Creativo_Backend.Servicios.Controllers.TecnicaArtisticas
{
    public class CreateTecnicaArtisticaController : ICreateTecnicaArtisticaController
    {
        private readonly ICreateTecnicaArtisticaPresenter _presenter;
        private readonly ICreateTecnicaArtisticaInputPort _inputPort;

        public CreateTecnicaArtisticaController(
            ICreateTecnicaArtisticaPresenter presenter, 
            ICreateTecnicaArtisticaInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<int> Handle(ICreateTecnicaArtisticaDto dto)
        {
            await _inputPort.Handle(dto);

            return _presenter.TecnicaArtisticaId;
        }
    }
}
