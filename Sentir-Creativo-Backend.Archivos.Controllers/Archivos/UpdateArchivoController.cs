using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Update;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;

namespace Sentir_Creativo_Backend.Archivos.Controllers.Archivos;

public class UpdateArchivoController : IUpdateArchivoController
{
    private readonly IUpdateArchivoInputPort _inputPort;
    private readonly IUpdateArchivoPresenter _presenter;
    
    public UpdateArchivoController(IUpdateArchivoInputPort inputPort, IUpdateArchivoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(UpdateArchivoDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.ArchivoId;
    }
}