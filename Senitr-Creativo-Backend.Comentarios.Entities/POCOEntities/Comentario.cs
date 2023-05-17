using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Senitr_Creativo_Backend.Comentarios.Entities.POCOEntities;

public class Comentario : BaseEntity<int>
{
    public string? Descripcion { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }
    public UserAdmin? User { get; set; }

}