using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class UsuarioArchivo : BaseEntity<int>
{
    public int UsuarioId { get; set; }
    public int ArchivoId { get; set; }
    
    //relaciones
    public virtual UsuarioAdmin Usuario { get; set; }
    public virtual Archivo Archivo { get; set; }
    
}