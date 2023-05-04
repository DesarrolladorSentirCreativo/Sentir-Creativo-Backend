namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Create;

public interface ICreateComentarioOutputPort
{
    ValueTask Handle(int comentarioId);
}