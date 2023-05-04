using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Create;

namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;

public interface ICreateComentarioPresenter : ICreateComentarioOutputPort
{
    int ComentarioId { get; }
}