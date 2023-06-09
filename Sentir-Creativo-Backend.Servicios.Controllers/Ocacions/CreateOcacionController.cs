﻿
namespace Sentir_Creativo_Backend.Servicios.Controllers.Ocacions
{
    public class CreateOcacionController : ICreateOcacionController
    {

        private readonly ICreateOcacionPresenter _presenter;
        private readonly ICreateOcacionInputPort _inputPort;

        public CreateOcacionController(
            ICreateOcacionPresenter presenter,
            ICreateOcacionInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<int> Handle(CreateOcacionDto dto)
        {
            await _inputPort.Handle(dto);

            return _presenter.OcacionId;

        }
    }
}
