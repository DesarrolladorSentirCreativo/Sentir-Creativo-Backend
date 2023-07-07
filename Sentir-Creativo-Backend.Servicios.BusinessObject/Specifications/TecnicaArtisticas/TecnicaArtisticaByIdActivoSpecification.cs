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
