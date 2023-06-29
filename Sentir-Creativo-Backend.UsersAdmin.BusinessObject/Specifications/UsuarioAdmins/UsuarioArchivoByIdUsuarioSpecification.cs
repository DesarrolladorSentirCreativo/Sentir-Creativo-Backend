namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins
{
    public class UsuarioArchivoByIdUsuarioSpecification : BaseSpecification<UsuarioArchivo>
    {
        public UsuarioArchivoByIdUsuarioSpecification(int usuarioAdminId) 
            : base(p => p.UsuarioId == usuarioAdminId)
        {
            AddInclude(p => p.Archivo!);
            AddInclude(p => p.Archivo!.TipoArchivo!);
        }
    }
}
    

