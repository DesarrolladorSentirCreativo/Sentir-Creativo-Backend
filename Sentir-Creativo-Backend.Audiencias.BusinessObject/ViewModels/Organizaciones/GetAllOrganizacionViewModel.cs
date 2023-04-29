
namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

public class GetAllOrganizacionViewModel
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string? Website { get; set; }
    public string? Facebook { get; set; }
    public string? Twitter { get; set; }
    public string? Instagram { get; set; }
    public string? Historial { get; set; }
    public string? Email { get; set; }
    public int? RubroId { get; set; }
    public long? Telefono { get; set; }
    public bool Activo { get; set; }
    public DateTime? PublishedAt { get; set; }
}