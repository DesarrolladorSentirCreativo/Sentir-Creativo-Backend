namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaUserAdmins;

public class CreateCategoriaUserAdminDto
{
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public int UserId { get; set; }
}