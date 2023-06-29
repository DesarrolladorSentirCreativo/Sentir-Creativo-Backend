namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;

public class UsuarioPrivilegioByIdUsuarioSpecification : BaseSpecification<UsuarioPrivilegio>
{
    public UsuarioPrivilegioByIdUsuarioSpecification(int usuarioAdminId)
        : base(x => x.UsuarioId == usuarioAdminId)
    {
        
    }
}