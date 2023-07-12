

namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Specifications.PublicoObjetivos
{
    public class PublicoObjetivoByIdActivoSpecification : BaseSpecification<PublicoObjetivo>
    {
        public PublicoObjetivoByIdActivoSpecification(int publicoObjetivoId)
            : base(x => x.Activo == true && x.Id == publicoObjetivoId)
        { 
        }
    }
}
