namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

public class GetAllSucursalViewModel
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public int PaisId { get; set; }
    public int RegionId { get; set; }
    public int ComunaId{ get; set; }
    public string Direccion { get; set; }
    public DateTime? CreatedAt { get; set; }
    
}