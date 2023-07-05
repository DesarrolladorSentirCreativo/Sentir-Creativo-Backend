namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Delete
{
    public interface IDeleteTecnicaArtisticaInputPort
    {
        ValueTask Handle(int tecnicaArtisticaId);
    }
}
