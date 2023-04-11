namespace Sentir_Creativo_Backend.Difusiones.Entities.ViewModels;

public class DifusionViewModel
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public DateTime? PublishedAt { get; set; }
    public bool Activo { get; set; }
    public int? PlataformaId { get; set; }
    public int? CuponDescuentoId { get; set; }
    public int? ColeccionId { get; set; }
    public string? Slogan { get; set; }
    public string? Asunto { get;set; }
    public string? PreHeader { get; set; }
    public int? PlantillaId { get; set; }
}