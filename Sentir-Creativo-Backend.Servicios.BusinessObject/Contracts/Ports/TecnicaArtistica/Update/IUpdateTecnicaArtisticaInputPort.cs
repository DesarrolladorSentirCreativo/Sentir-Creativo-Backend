using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.TecnicaArtisticas;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Update
{
    public interface IUpdateTecnicaArtisticaInputPort
    {
        ValueTask Handle(UpdateTecnicaArtisticaDto dto);
    }
}
