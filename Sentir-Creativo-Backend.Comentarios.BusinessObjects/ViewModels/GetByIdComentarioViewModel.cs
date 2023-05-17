namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.ViewModels;

public class GetByIdComentarioViewModel
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public DateTime? PublishedAt { get; set; }
    public string Usuario { get; set; }
}