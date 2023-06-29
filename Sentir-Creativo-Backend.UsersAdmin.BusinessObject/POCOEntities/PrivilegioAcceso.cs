namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class PrivilegioAcceso : BaseEntity<int>
{
    public string AccesoId { get; set; }
    public string PrivilegioId { get; set; }
    
    public virtual Privilegio Privilegio { get; set; }
    public virtual Acceso Acceso { get; set; }
}