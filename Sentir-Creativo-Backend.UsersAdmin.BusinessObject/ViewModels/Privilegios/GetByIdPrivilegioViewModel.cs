namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

public class GetByIdPrivilegioViewModel
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public int CategoriaId { get; set; }
    public string? Descripcion { get; set; }
    public IReadOnlyList<AccesoViewModel> Accesos { get; set; }
    
}