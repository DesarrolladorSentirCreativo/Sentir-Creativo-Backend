using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class PrivilegioAcceso : BaseEntity<int>
{
    public int AccesoId { get; set; }
    public int PrivilegioId { get; set; }
    
    public virtual Privilegio Privilegio { get; set; }
    public virtual Acceso Acceso { get; set; }
}