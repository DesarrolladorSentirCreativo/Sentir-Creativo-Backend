using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins
{
    public class UsuarioRolWithRelationsSpecification : BaseSpecification<UsuarioRol>
    {
        public UsuarioRolWithRelationsSpecification(int usuarioId): base(x => x.UsuarioId == usuarioId)
        {
            AddInclude(p => p.Rol);
        }
    }
}
