using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.TecnicaArtisticas;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas
{
    public interface ICreateTecnicaArtisticaController
    {
        ValueTask<int> Handle(CreateTecnicaArtisticaDto dto);
    }
}
