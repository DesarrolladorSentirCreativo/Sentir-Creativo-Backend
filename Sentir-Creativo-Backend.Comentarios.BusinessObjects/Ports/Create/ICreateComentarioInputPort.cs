using Senitr_Creativo_Backend.Comentarios.Entities.DTO;

namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Create;

public interface ICreateComentarioInputPort
{
    ValueTask Handle(CreateComentarioDto dto);
}