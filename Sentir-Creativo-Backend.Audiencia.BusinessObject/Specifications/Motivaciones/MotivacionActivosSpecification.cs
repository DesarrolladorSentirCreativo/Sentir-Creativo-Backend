using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Motivaciones;

public class MotivacionActivosSpecification : BaseSpecification<Motivacion>
{
    public MotivacionActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}