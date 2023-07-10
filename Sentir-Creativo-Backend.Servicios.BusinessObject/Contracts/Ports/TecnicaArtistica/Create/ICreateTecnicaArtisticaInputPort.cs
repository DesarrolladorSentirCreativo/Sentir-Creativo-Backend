using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.TecnicaArtisticas;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Create
{
    public interface ICreateTecnicaArtisticaInputPort 
    {
        ValueTask Handle(CreateTecnicaArtisticaDto dto);
        
    }
}
