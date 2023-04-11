namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

public class SearchAudienciasDifusionViewModel
{
    public int DifusionId { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public bool Activo { get; set; }
    public int? PlataformaId { get; set; }
    public int? CuponDescuentoId { get; set; }
    public int? ColeccionId { get; set; }
    public string? Slogan { get; set; }
    public string? Asunto { get;set; }
    public string? PreHeader { get; set; }
    public int? PlantillaId { get; set; }
    public string? Plataforma { get; set; }
    public string? Plantilla { get; set; }
    public string? Coleccion { get; set; }
    public string? CuponDescuento { get; set; }
    
    
    public IReadOnlyList<AudienciaViewModel> Audiencias { get; set; }
}