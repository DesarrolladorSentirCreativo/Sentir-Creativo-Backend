namespace Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

public class Sucursal : BaseEntity<int>
{
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public string Direccion { get; set; }
    public int PaisId { get; set; }
    public int RegionId { get; set; }
    public int ComunaId { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int? UpdatedBy { get; set; }
    public bool Activo { get; set; }
}