using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;

namespace Sentir_Creativo_Backend.Comentarios.Presenters.Comentarios;

public class DeleteComentarioPresenter : IDeleteComentarioPresenter
{
    public int ComentarioId { get; private set; }
    
    public ValueTask Handle(int comentarioId)
    {
        ComentarioId = comentarioId;

        return ValueTask.CompletedTask;
    }
}