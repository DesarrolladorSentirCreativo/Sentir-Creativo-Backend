using Sentir_Creativo_Backend.Servicios.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.Formatos;

public class FormatoActivosSpecification  : BaseSpecification<Formato>
{
    public FormatoActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}