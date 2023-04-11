using Sentir_Creativo_Backend.PublicoObjetivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Specifications.PublicoObjetivos;

public class PublicoObjetivosActivosSpecification : BaseSpecification<PublicoObjetivo>
{
    public PublicoObjetivosActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}