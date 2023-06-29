namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins
{
    public class UsuarioAdminFindByIdEmailSpecification : BaseSpecification<UsuarioAdmin>
    {
        public UsuarioAdminFindByIdEmailSpecification(string email)
            : base(u => u.Email == email)
        {
        }
    }
}
    

