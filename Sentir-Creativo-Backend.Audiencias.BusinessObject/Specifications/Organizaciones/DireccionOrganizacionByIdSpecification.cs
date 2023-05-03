using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Organizaciones;

public class DireccionOrganizacionByIdSpecification : BaseSpecification<OrganizacionDireccion>
{
    public DireccionOrganizacionByIdSpecification(int organizacionId) 
        : base(x => x.OrganizacionId == organizacionId)
    {
        AddInclude(p => p.Direccion!);
    }
}