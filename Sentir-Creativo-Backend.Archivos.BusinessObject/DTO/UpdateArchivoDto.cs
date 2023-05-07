namespace Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;

public class UpdateArchivoDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string? Path { get; set; }
    public int TipoArchivoId { get; set; }
    public bool? Publico { get; set; }
    public int UserId { get; set; }
}