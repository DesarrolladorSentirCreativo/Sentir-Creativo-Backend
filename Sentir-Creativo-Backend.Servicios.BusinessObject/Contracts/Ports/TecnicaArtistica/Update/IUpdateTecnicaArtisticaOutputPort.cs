namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Update
{
    public interface IUpdateTecnicaArtisticaOutputPort
    {
        ValueTask Handle(int tecnicaArtisticaId);
    }
}
