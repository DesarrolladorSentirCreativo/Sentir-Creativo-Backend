using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

public class AudienciaArchivo : BaseEntity<int>
{
    public int AudienciaId { get; set; }
    public int ArchivoId { get; set; }
    
    public Audiencias.Entities.POCOEntities.Audiencia? Audiencia { get; set; }
    public Archivo? Archivo { get; set; }
}