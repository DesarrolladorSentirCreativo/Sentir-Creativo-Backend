namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.TecnicaArtisticas
{
    public class TecnicaArtisticaActivosSpecification : BaseSpecification<TecnicaArtistica>
    {
        public TecnicaArtisticaActivosSpecification(): base(x => x.Activo == true)
        {

        }
    }
}
