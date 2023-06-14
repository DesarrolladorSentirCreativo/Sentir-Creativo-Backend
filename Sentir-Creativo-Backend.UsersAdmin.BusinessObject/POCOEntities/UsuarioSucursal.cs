using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class UsuarioSucursal : BaseEntity<int>
{
    public int UsuarioId { get; set; }
    public int SucursalId { get; set; }
    
    //relaciones
    public virtual UsuarioAdmin Usuario { get; set; }
    public virtual Sucursal Sucursal { get; set; }
}