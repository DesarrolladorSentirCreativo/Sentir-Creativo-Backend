namespace Sentir_Creativo_Backend.Bitacoras.BusinessObjects.DTO;

public class CreateBitacoraDto
{
    public string? Entidad { get; set; }
    public string? Accion { get; set; }
    public string? Autor { get; set; }
    public string? Contenido { get; set; }
    public string? Via { get; set; }
    public DateTime? Fecha { get; set; }
    public int? UserId { get; set; }
}