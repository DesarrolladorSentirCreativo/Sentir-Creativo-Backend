using Senitr_Creativo_Backend.Comentarios.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

public class AudienciaComentario : BaseEntity<int>
{
    public int? AudienciaId { get; set; }
    public int? ComentarioId { get; set; }
    public bool Activo { get; set; }
    
    public Audiencias.Entities.POCOEntities.Audiencia? Audiencia { get; set; }
    public Comentario? Comentario { get; set; }
}