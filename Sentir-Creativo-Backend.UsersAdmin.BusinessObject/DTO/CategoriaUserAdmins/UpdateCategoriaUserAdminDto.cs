namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaUserAdmins;

public class UpdateCategoriaUserAdminDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public int UserId { get; set; }
}