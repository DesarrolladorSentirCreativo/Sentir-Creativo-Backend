namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.EstadoUserAdmins;

public class UpdateEstadoUserAdminDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Color { get; set; }
    public string? Descripcion { get; set; }
    public int UserId { get; set; }
}