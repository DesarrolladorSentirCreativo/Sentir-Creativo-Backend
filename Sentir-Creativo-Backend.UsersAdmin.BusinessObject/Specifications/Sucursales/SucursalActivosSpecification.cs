namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Sucursales;

public class SucursalActivosSpecification : BaseSpecification<Sucursal>
{
    public SucursalActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}