namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

public class UpdateAccesoDto
{
    public bool Crear { get; set; }
    public bool Actualizar { get; set; }
    public bool Eliminar { get; set; }
    public bool Ver { get; set; }
    public int ColeccionId { get; set; }
    public bool Listar { get; set; }
}