namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Modulos;

public class ModuloActivosSpecification : BaseSpecification<Modulo>
{
    public ModuloActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}