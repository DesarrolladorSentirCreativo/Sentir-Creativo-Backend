using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

public class GetAllWithColeccionesModuloViewModel
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public IReadOnlyList<GetAllColeccionUserAdminViewModel> colecciones { get; set; }
}