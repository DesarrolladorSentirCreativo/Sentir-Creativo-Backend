namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;

public class UpdateSucursalDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public string Direccion { get; set; }
    public int PaisId { get; set; }
    public int RegionId { get; set; }
    public int CiudadId { get; set; }
    public int UserId { get; set; }
}