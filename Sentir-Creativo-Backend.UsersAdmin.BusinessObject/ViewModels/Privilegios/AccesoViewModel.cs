namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

public class AccesoViewModel
{
    public string Id { get; set; }
    public int ColeccionId { get; set; }
    public bool Crear { get; set; }
    public bool Actualizar { get; set; }
    public bool Eliminar { get; set; }
    public bool Ver { get; set; }
    public bool Listar { get; set; }
}