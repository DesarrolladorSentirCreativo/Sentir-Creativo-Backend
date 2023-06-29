namespace Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

public class Rol : BaseEntity<int>
{
    public string Nombre { get; set;}
    public string? Descripcion { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? PublishedAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int? UpdatedBy { get; set; }
    public bool Activo { get; set; }
}