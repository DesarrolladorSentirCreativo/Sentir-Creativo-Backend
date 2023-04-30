using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

public class OrganizacionDireccion : BaseEntity<int>
{
    public int OrganizacionId { get; set; }
    public int DireccionId { get; set; }
    public bool Predeterminada { get; set; }
    
    public Organizacion? Organizacion { get; set; }
    public Direccion?  Direccion { get; set; }
}