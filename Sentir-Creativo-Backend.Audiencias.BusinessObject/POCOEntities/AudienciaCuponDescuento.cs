using Sentir_Creativo_Backend.CuponDescuentos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

public class AudienciaCuponDescuento : BaseEntity<int>
{
    public int? AudienciaId { get; set; }
    public int? CuponDescuentoId { get; set; }
    public bool? Activo { get; set; }
    
    public virtual Audiencias.Entities.POCOEntities.Audiencia? Audiencia { get; set; }
    public virtual CuponDescuento? CuponDescuento { get;set; }
    
}