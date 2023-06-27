using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins
{
    public class UsuarioSucursalWithRelationsSpecification : BaseSpecification<UsuarioSucursal>
    {
        public UsuarioSucursalWithRelationsSpecification(int usuarioAdminId)
            : base(x => x.UsuarioId == usuarioAdminId)
        {
            AddInclude(x => x.Sucursal);
        }
    }
}
    

