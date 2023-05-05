namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Delete;

public interface IDeleteComentarioInputPort
{
    ValueTask Handle(int comentarioId);
}