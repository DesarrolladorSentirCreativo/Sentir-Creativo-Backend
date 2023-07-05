namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas
{
    public interface IDeleteTecnicaArtisitcaController
    {
        ValueTask<int> Handle(int tecnicaArtisticaId);
    }
}
