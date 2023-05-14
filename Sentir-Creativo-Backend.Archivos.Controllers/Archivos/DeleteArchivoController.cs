using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Delete;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;

namespace Sentir_Creativo_Backend.Archivos.Controllers.Archivos;

public class DeleteArchivoController : IDeleteArchivoController
{
    private readonly IDeleteArchivoInputPort _inputPort;
    private readonly IDeleteArchivoPresenter _presenter;
    
    public DeleteArchivoController(IDeleteArchivoInputPort inputPort,
        IDeleteArchivoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int archivoId)
    {
        await _inputPort.Handle(archivoId);
        return _presenter.ArchivoId;
    }
}