namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class UsuarioComentario : BaseEntity<int>
{
    public int UsuarioId { get; set; }
    public int ComentarioId { get; set; }
    
    //relaciones
    public virtual UsuarioAdmin Usuario { get; set; }
    public virtual Comentario Comentario { get; set; }
}