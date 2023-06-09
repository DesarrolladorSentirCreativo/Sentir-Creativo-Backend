namespace Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

public class CategoriaUserAdmin : BaseEntity<int>
{
    public string Nombre { get; set;}
    public string? Descripcion { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int? UpdatedBy { get; set; }
    public bool Activo { get; set; }
}