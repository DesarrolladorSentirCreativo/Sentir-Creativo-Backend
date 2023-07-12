namespace Sentir_Creativo_Backend.PublicoObjetivos.Controllers.PublicoObjetivos
{
    public class GetByIdPublicoObjetivoController : IGetByIdPublicoObjetivoController
    {
        private readonly IGetByIdPublicoObjetivoInputPort _inputPort;
        private readonly IGetByIdPublicoObjetivoPresenter _presenter;

        public GetByIdPublicoObjetivoController(IGetByIdPublicoObjetivoInputPort inputPort, IGetByIdPublicoObjetivoPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<GetByIdPublicoObjetivoViewModel> Handle(int publicoObjetivoId)
        {
            await _inputPort.Handle(publicoObjetivoId);

            return _presenter.ViewModel;
        }
    }
}
