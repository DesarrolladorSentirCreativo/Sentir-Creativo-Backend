namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

public class AudienciaViewModel
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Profesion { get; set; }
    public string Email { get; set; }
    public string? Celular { get; set; }
    public string? Organizacion { get; set; }
    public string? DocumentoIdentidad  { get; set; }
    public bool Activo { get; set; }
}