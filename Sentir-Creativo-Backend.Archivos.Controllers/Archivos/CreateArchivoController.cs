using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Create;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;

namespace Sentir_Creativo_Backend.Archivos.Controllers.Archivos;

public class CreateArchivoController : ICreateArchivoController
{
    private readonly ICreateArchivoInputPort _inputPort;
    private readonly ICreateArchivoPresenter _presenter;
    
    public CreateArchivoController(ICreateArchivoInputPort inputPort, ICreateArchivoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateArchivoDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.ArchivoId;
    }
}