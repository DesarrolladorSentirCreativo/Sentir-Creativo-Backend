namespace Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

public class CuentaBancaria : BaseEntity<int>
{
    public string Banco { get; set; }
    public string TipoCuenta { get; set; }
    public string NumCuenta { get; set; }
    public bool Activo { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }
}