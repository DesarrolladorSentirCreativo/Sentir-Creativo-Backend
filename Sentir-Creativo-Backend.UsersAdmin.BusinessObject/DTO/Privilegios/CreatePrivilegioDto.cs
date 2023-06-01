namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

public class CreatePrivilegioDto
{
    public string Nombre { get; set; }
    public int CategoriaId { get; set; }
    public string? Descripcion { get; set; }
    public int UserId { get; set; }
    public IReadOnlyList<CreateAccesoDto> Accesos { get; set; }
}