namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class RolAcuerdo : BaseEntity<int>
{
    public int AcuerdoId { get; set; }
    public int RolId { get; set; }
    
    public virtual Rol Rol { get; set; }
    public virtual AcuerdoUserAdmin Acuerdo { get; set; }
}
