using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Bitacoras.Entities.POCOEntities;

public class Bitacora : BaseEntity<int>
{
    public string? Entidad { get; set; }
    public string? Accion { get; set; }
    public string? Autor { get; set; }
    public string? Contenido { get; set; }
    public string? Via { get; set; }
    public DateTime? Fecha { get; set; }
}