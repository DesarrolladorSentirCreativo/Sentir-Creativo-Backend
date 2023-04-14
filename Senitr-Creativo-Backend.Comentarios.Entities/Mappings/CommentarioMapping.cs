using Senitr_Creativo_Backend.Comentarios.Entities.DTO;
using Senitr_Creativo_Backend.Comentarios.Entities.ViewModels;

namespace Senitr_Creativo_Backend.Comentarios.Entities.Mappings;

public static class CommentarioMapping
{
    public static IReadOnlyList<IdComentarioViewModel> Handle(IReadOnlyList<IdComentarioDto> dtos)
    {
        return dtos
            .Select(p => 
                new IdComentarioViewModel() { ComentarioId = p.ComentarioId })
            .ToList()
            .AsReadOnly();
    }
}