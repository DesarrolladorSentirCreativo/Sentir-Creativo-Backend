using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Organizaciones;

public class OrganizacionDireccionSpecification : BaseSpecification<OrganizacionDireccion>
{
    public OrganizacionDireccionSpecification() : base(x => x.Organizacion!.Activo == true)
    {
        AddInclude(p => p.Organizacion!);
        AddInclude(p => p.Direccion!);
        AddInclude(p => p.Direccion!.Ciudad!);
    }
}