using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Update;

namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;

public interface IUpdateComentarioPresenter : IUpdateComentarioOutputPort
{
    int ComentarioId { get; }
}