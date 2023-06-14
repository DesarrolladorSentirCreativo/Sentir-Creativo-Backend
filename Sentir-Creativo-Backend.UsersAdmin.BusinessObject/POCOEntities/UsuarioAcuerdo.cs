using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class UsuarioAcuerdo : BaseEntity<int>
{
    public int UsuarioId { get; set; }
    public int AcuerdoId { get; set; }
    
    //relaciones
    public UsuarioAdmin Usuario { get; set; }
    public AcuerdoUserAdmin Acuerdo { get; set; }
}