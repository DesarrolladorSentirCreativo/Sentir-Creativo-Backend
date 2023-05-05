namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.DTO;

public class UpdateComentarioDto
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public int UserId { get; set; }
}