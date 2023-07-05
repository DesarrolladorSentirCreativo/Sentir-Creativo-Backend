using Sentir_Creativo_Backend.Servicios.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.TecnicaArtisticas
{
    public class TecnicaArtisticaByIdActivoSpecification : BaseSpecification<TecnicaArtistica>
    {
        public TecnicaArtisticaByIdActivoSpecification(int tecnicaArtisticaId)
            : base(x => x.Id == tecnicaArtisticaId && x.Activo == true)
        {

        }
    }
}
