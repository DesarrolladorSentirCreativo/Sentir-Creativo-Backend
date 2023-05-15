namespace Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

public class GetByIdArchivoViewModel
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Path { get; set; }
    public int? TipoArchivoId { get; set; }
    public bool? Publico { get; set; }
    public DateTime? PublishedAt { get; set; }
}