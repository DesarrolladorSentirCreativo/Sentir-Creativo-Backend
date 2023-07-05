namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetById
{
    public interface IGetByIdTecnicaArtisticaInputPort
    {
        ValueTask Handle(int tecnicaArtisticaId);
    }
}
