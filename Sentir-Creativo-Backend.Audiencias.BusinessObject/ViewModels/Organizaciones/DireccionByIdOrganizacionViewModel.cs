namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

public class DireccionByIdOrganizacionViewModel
{
    public int DireccionId { get; set; }
    public int PaisId { get; set; }
    public int RegionId { get; set; }
    public int CiudadId { get; set; }
    public string? Calle { get; set; }
}