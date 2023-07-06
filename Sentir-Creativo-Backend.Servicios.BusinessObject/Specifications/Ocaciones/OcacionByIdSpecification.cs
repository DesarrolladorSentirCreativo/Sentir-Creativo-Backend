
using Sentir_Creativo_Backend.Servicios.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.Ocaciones
{
    public class OcacionByIdSpecification : BaseSpecification<Ocacion>
    {
        public OcacionByIdSpecification(int OcacionId)
       : base(x => x.Id == OcacionId && x.Activo == true ) 
        {

        }
    }
}
