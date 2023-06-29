namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;

public class UsuarioRolByIdUsuarioSpecification : BaseSpecification<UsuarioRol>
{
    public UsuarioRolByIdUsuarioSpecification(int usuarioAdminId)
        : base(x => x.UsuarioId == usuarioAdminId)
    {
        
    }
}