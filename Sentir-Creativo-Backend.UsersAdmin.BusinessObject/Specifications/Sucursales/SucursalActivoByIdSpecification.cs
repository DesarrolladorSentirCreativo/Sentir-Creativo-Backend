namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Sucursales;

public class SucursalActivoByIdSpecification : BaseSpecification<Sucursal>
{
    public SucursalActivoByIdSpecification(int sucursalId) 
        : base(x => x.Id == sucursalId && x.Activo == true)
    {
        
    } 
    
}