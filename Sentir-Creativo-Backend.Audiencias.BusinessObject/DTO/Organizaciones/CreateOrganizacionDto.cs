namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Organizaciones;

public class CreateOrganizacionDto
{
    public string Nombre { get; set; }
    public int RubroId { get; set; }
    public int PaisId { get; set; }
    public int RegionId { get; set; }
    public int CiudadId { get; set; }
    public string? Calle { get; set; }
    public string? Website { get; set; }
    public string? Facebook { get; set; }
    public string? Twitter { get; set; }
    public string? Instagram { get; set; }
    public string? Historial { get; set; }
    public string? Email { get; set; }
    public long? Telefono { get; set; }
    public int UserId { get; set; }
}