namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Delete
{
    public interface IDeleteTecnicaArtisticaOutputPort
    {
        ValueTask Handle(int tecnicaArtisticaId);
    }
}
