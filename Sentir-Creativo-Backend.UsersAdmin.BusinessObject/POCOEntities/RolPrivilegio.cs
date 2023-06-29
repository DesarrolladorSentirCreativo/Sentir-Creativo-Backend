namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class RolPrivilegio : BaseEntity<int>
{
    public string PrivilegioId { get; set; }
    public int RolId { get; set; }
    
    public virtual Rol Rol { get; set; }
    public virtual Privilegio Privilegio { get; set; }
}