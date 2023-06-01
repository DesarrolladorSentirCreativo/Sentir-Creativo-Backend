using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

public class Privilegio : BaseEntity<int>
{
    public string Nombre { get; set; }
    public int CategoriaId { get; set; }
    public string? Descripcion { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int? UpdatedBy { get; set; }
    public bool Activo { get; set; }
    
    public virtual CategoriaPrivilegio Categoria { get; set; }
}