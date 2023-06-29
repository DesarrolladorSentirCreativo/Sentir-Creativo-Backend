namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Privilegios;

public class AccesoByIdSpecification : BaseSpecification<Acceso>
{
    public AccesoByIdSpecification(IReadOnlyList<AccesoId> accesos)
        : base(p => accesos.Select(a => a.Id).Contains(p.Id))
    {
        
    }
}