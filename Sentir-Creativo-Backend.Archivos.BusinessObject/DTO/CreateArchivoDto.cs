namespace Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;

public class CreateArchivoDto
{
    public string Nombre { get; set; }
    public string? Path { get; set; }
    public int TipoArchivoId { get; set; }
    public bool? Publico { get; set; }
}