namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Create
{
    public interface ICreateTecnicaArtisticaOutputPort
    {
        ValueTask Handle(int tecnicaArtisticaId);
    }
}
