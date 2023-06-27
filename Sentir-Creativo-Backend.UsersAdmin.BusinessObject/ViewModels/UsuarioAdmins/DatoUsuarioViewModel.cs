namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins
{
    public class DatoUsuarioViewModel
    {
        public int UserId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Alias { get; set; }
        
        public IReadOnlyList<UsuarioAdminSucursalViewModel> Sucursales { get; set; }
        public IReadOnlyList<UsuarioAdminAccesoViewModel> Accesos { get; set; }
    }
}
