namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Previsiones;

public class CreatePrevisionDto
{
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public int UserId { get; set; }
}