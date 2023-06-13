namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ModoTrabajos;

public class CreateModoTrabajoDto
{
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public int UserId { get; set; }
}