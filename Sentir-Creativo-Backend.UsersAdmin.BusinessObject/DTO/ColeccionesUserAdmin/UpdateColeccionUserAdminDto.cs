namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ColeccionesUserAdmin;

public class UpdateColeccionUserAdminDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int ModuloId { get; set; }
    public string? Descripcion { get; set; }
    public int UserId { get; set; }
}