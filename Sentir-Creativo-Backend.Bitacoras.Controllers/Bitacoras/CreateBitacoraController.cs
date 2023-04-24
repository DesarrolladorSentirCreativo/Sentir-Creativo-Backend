using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Controllers.Bitacoras;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.DTO;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Ports.Bitacoras.Create;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Presenters.Bitacoras;

namespace Sentir_Creativo_Backend.Bitacoras.Controllers.Bitacoras;

public class CreateBitacoraController : ICreateBitacoraController
{
    private readonly ICreateBitacoraInputPort _inputPort;
    private readonly ICreateBitacoraPresenter _presenter;
    
    public CreateBitacoraController(ICreateBitacoraInputPort inputPort, ICreateBitacoraPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateBitacoraDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.BitacoraId;
    }
}