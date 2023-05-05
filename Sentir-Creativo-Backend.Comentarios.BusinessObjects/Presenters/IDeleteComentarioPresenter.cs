using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Delete;

namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;

public interface IDeleteComentarioPresenter : IDeleteComentarioOutputPort
{
    int ComentarioId { get; }
}