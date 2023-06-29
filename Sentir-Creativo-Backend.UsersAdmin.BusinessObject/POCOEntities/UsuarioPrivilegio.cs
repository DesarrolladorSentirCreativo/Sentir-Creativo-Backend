namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class UsuarioPrivilegio : BaseEntity<int>
{
    public int UsuarioId { get; set; }
    public string PrivilegioId { get; set; }
    
    //relaciones
    public virtual UsuarioAdmin Usuario { get; set; }
    public virtual Privilegio Privilegio { get; set; }
}