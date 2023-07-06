using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Ocacions;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.TecnicaArtisticas;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Update
{
    public interface IUpdateTecnicaArtisticaInputPort
    {
        ValueTask Handle(UpdateTecnicaArtisticaDto dto);
       
    }
}
