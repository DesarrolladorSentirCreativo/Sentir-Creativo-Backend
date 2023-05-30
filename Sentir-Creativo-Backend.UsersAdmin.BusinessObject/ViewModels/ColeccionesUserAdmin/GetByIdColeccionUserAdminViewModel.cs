namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

public class GetByIdColeccionUserAdminViewModel
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int ModuloId { get; set; }
    public string? Descripcion { get; set; }
}