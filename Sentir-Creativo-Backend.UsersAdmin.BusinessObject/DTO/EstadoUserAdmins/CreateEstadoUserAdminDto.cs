namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.EstadoUserAdmins;

public class CreateEstadoUserAdminDto
{
    public string Nombre { get; set; }
    public string Color { get; set; }
    public string? Descripcion { get; set; }
    public int UserId { get; set; }
}