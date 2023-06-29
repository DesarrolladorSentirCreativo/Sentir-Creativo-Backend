namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class UsuarioRol : BaseEntity<int>
{
    public int UsuarioId { get; set; }
    public int RolId { get; set; }
    
    //relaciones
    public virtual UsuarioAdmin Usuario { get; set; }
    public virtual Rol Rol { get; set; }
}