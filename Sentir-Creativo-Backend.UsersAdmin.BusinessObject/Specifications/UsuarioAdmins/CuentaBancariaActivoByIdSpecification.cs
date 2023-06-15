using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;

public class CuentaBancariaActivoByIdSpecification : BaseSpecification<CuentaBancaria>
{
    public CuentaBancariaActivoByIdSpecification(int cuentaBancariaId) :
        base(x => x.Id == cuentaBancariaId && x.Activo == true)
    {
        
    }
}