namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

public class UpdatePrivilegioDto
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public int CategoriaId { get; set; }
    public string? Descripcion { get; set; }
    public int UserId { get; set; }
    
    public IReadOnlyList<UpdateAccesoDto> Accesos { get; set; }
}