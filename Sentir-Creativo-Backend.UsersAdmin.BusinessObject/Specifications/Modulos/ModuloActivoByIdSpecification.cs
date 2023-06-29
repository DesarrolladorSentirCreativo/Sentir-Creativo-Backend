namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Modulos;

public class ModuloActivoByIdSpecification : BaseSpecification<Modulo>
{
    public ModuloActivoByIdSpecification(int moduloId) 
        : base(x => x.Id == moduloId && x.Activo == true)
    {
        
    }
}