namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Delete;

public interface IDeleteComentarioOutputPort
{
    ValueTask Handle(int comentarioId);
}