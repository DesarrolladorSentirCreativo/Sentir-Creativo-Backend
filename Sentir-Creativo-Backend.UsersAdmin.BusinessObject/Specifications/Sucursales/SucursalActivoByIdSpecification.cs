using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Sucursales;

public class SucursalActivoByIdSpecification : BaseSpecification<Sucursal>
{
    public SucursalActivoByIdSpecification(int sucursalId) 
        : base(x => x.Id == sucursalId && x.Activo == true)
    {
        
    } 
    
}