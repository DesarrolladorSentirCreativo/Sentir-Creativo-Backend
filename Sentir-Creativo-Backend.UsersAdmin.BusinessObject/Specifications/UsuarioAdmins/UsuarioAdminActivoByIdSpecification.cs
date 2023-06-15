using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;

public class UsuarioAdminActivoByIdSpecification : BaseSpecification<UsuarioAdmin>
{
    public UsuarioAdminActivoByIdSpecification(int usuarioAdminId) 
        : base(x => x.Id == usuarioAdminId && x.Activo == true)
    {
    }
}