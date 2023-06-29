namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins
{
    public class PrivilegioUsuarioRolWithRelationsSpecification : BaseSpecification<RolPrivilegio>
    {
        public PrivilegioUsuarioRolWithRelationsSpecification(List<int> roles) : base(x => roles.Contains(x.RolId))
        {
           
        }
    }
}

                                                                          
    
