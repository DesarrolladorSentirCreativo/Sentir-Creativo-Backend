using Sentir_Creativo_Backend.Colecciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.CuponDescuentos.Entities.POCOEntities;
using Sentir_Creativo_Backend.Plantillas.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Difusiones.Entities.POCOEntities;

public class Difusion : BaseEntity<int>
{
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }
    public bool Activo { get; set; }
    public int? PlataformaId { get; set; }
    public int? CuponDescuentoId { get; set; }
    public int? ColeccionId { get; set; }
    public string? Slogan { get; set; }
    public string? Asunto { get;set; }
    public string? PreHeader { get; set; }
    public int? PlantillaId { get; set; }
    
    public virtual Plataforma? Plataforma { get; set; }
    public virtual CuponDescuento? CuponDescuento { get; set; }
    public virtual Coleccion? Coleccion { get; set; }
    public virtual Plantilla? Plantilla { get; set; }
}
    
    