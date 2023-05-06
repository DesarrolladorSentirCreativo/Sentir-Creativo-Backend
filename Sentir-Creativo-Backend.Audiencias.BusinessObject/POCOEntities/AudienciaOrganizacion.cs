using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

public class AudienciaOrganizacion : BaseEntity<int>
{
    public int AudienciaId { get; set; }
    public int OrganizacionId { get; set; }
    
    public virtual Audiencias.Entities.POCOEntities.Audiencia? Audiencia { get; set; }
    public virtual Organizacion? Organizacion { get;set; }
}