namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Modulos;

public class ModuloByIdsSpecification : BaseSpecification<Modulo>
{
    public ModuloByIdsSpecification(IReadOnlyList<ColeccionUserAdmin> colecciones)
        : base(p => colecciones.Select(a => a.ModuloId).Contains(p.Id))
    {
        
    }
        
}