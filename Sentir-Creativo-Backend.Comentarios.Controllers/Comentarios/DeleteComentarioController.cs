using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Delete;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;

namespace Sentir_Creativo_Backend.Comentarios.Controllers.Comentarios;

public class DeleteComentarioController : IDeleteComentarioController
{
    private readonly IDeleteComentarioInputPort _inputPort;
    private readonly IDeleteComentarioPresenter _presenter;
    
    public DeleteComentarioController(
        IDeleteComentarioInputPort inputPort, 
        IDeleteComentarioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int comentarioId)
    {
        await _inputPort.Handle(comentarioId);
        return _presenter.ComentarioId;
    }
}