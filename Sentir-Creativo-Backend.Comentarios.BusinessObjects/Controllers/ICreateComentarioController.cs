using Senitr_Creativo_Backend.Comentarios.Entities.DTO;

namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;

public interface ICreateComentarioController
{
    ValueTask<int> Handle(CreateComentarioDto dto);
}